﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;

namespace TheBall.Infra.TheBallWebConsole
{
    public class WebConsoleConfig
    {
        public int PollingIntervalSeconds { get; set; }

        public static async Task<WebConsoleConfig> GetConfig(string fullPathToConfig)
        {
            return new WebConsoleConfig { PollingIntervalSeconds = 30};
#if notyet
            using (var fileStream = File.OpenRead(fullPathToConfig))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                var data = await reader.ReadToEndAsync();
                return JSONSupport.GetObjectFromString<WebConsoleConfig>(data);
            }
#endif
        }

    }
    public class WebManager
    {
        private readonly string ConfigRootFolder;
        private readonly Stream HostPollingStream;
        private readonly WebConsoleConfig WebConfig;

        private WebManager(Stream hostPollingStream, WebConsoleConfig webConfig, string configRootFolder)
        {
            HostPollingStream = hostPollingStream;
            WebConfig = webConfig;
            ConfigRootFolder = configRootFolder;
        }

        internal static async Task<WebManager> Create(Stream hostPollingStream, string workerConfigFullPath)
        {
            var webConsoleConfig = await WebConsoleConfig.GetConfig(workerConfigFullPath);
            string configRootFolder = Path.GetDirectoryName(workerConfigFullPath);

            var webManager = new WebManager(hostPollingStream, webConsoleConfig, configRootFolder);
            return webManager;
        }

        private void InitStuff()
        {
            var storageAccountName = CloudConfigurationManager.GetSetting("CoreFileShareAccountName");
            var storageAccountKey = CloudConfigurationManager.GetSetting("CoreFileShareAccountKey");
            var StorageAccount = new CloudStorageAccount(new StorageCredentials(storageAccountName, storageAccountKey), true);

            var BlobClient = StorageAccount.CreateCloudBlobClient();
            var SiteContainerName = "";
            var InstanceSiteContainer = BlobClient.GetContainerReference(SiteContainerName);

            string hostsFileContents =
@"127.0.0.1 dev
127.0.0.1   test
127.0.0.1   prod
127.0.0.1   websites
";
            var hostsFilePath = Path.Combine(Environment.SystemDirectory, "drivers", "etc", "hosts");
            File.WriteAllText(hostsFilePath, hostsFileContents);


        }

        internal async Task RunUpdateLoop()
        {
            var pipeStream = HostPollingStream;
            var reader = pipeStream != null ? new StreamReader(pipeStream) : null;
            try
            {
                var pollingIntervalSeconds = WebConfig.PollingIntervalSeconds;

                string startupLogPath = Path.Combine(Program.AssemblyDirectory, "ConsoleStartupLog.txt");
                var startupMessage = "Starting up process (UTC): " + DateTime.UtcNow.ToString() +
                                     " with interval seconds: " + pollingIntervalSeconds;
                File.WriteAllText(startupLogPath, startupMessage);

                var pipeMessageAwaitable = reader?.ReadToEndAsync();

                while (true)
                {
                    var pollingDelay = Task.Delay(pollingIntervalSeconds*1000);
                    
                    // Do polling actions here

                    var awaits = pipeMessageAwaitable != null
                        ? new[] {pipeMessageAwaitable, pollingDelay}
                        : new[] {pollingDelay};
                    await Task.WhenAny(awaits);
                    bool isCanceling = pipeMessageAwaitable != null && pipeMessageAwaitable.IsCompleted;
                    if (isCanceling)
                    {
                        var pipeMessage = pipeMessageAwaitable.Result;
                        var shutdownLogPath = Path.Combine(Program.AssemblyDirectory, "ConsoleShutdownLog.txt");
                        File.AppendAllText(shutdownLogPath,
                            "Quitting for message (UTC): " + pipeMessage + " " + DateTime.UtcNow.ToString());
                        break;
                    }
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Dispose();
                    pipeStream.Dispose();
                }
            }
        }
    }
}
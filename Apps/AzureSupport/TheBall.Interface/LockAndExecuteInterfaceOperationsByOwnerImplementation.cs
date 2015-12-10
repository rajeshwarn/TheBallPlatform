using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.WindowsAzure.StorageClient;
using TheBall.CORE;

namespace TheBall.Interface
{
    public class LockAndExecuteInterfaceOperationsByOwnerImplementation
    {
        public static IContainerOwner GetTarget_QueueOwner()
        {
            return SystemSupport.SystemOwner;
        }

        public static string GetTarget_QueueLocation()
        {
            return OperationSupport.OperationQueueLocationName;
        }

        public static IEnumerable<IGrouping<string, string>> GetTarget_OwnerGroupedItems(IContainerOwner queueOwner,
            string queueLocation)
        {
            var blobList = queueOwner.ListBlobsWithPrefix(queueLocation).Cast<CloudBlockBlob>();
            var grouped = blobList.GroupBy(blob =>
            {
                var fileNamePart = Path.GetFileName(blob.Name);
                string timeStampPart;
                string ownerPrefix;
                string ownerID;
                string operationID;
                OperationSupport.GetQueueItemComponents(fileNamePart, out timeStampPart, out ownerPrefix, out ownerID,
                    out operationID);
                return ownerPrefix + "_" + ownerID;
            }, blob => blob.Name);
            return grouped;
        }

        public static string GetTarget_LockFileNameFormat()
        {
            return OperationSupport.LockFileNameFormat;
        }

        public static LockAndExecuteInterfaceOperationsByOwner.AcquireFirstObtainableLockReturnValue
            ExecuteMethod_AcquireFirstObtainableLock(IEnumerable<IGrouping<string, string>> ownerGroupedItems,
                IContainerOwner queueOwner, string queueLocation, string lockFileNameFormat)
        {
            var fullLockPathFormat =
                Path.Combine(queueOwner.GetOwnerPrefix(), queueLocation, lockFileNameFormat).Replace(@"\", "/");
            string currLockFile = null;
            foreach (var grp in ownerGroupedItems)
            {
                var ownerprefix_id = grp.Key;
                currLockFile = String.Format(fullLockPathFormat, ownerprefix_id);
                string lockEtag;
                bool acquireLock = StorageSupport.AcquireLogicalLockByCreatingBlob(currLockFile, out lockEtag);
                if (!acquireLock)
                    continue;
                var ownerOperationBlobNames = grp.ToArray();
                var ownerOperationIDs = ownerOperationBlobNames.Select(blobName =>
                {
                    var fileNamePart = Path.GetFileName(ownerOperationBlobNames.First());
                    string timestampPart;
                    string ownerPrefix;
                    string ownerID;
                    string operationID;
                    OperationSupport.GetQueueItemComponents(fileNamePart, out timestampPart, out ownerPrefix,
                        out ownerID, out operationID);
                    return new Tuple<string, string, string>(ownerPrefix, ownerID, operationID);
                }).ToArray();
                var result = new LockAndExecuteInterfaceOperationsByOwner.AcquireFirstObtainableLockReturnValue
                {
                    LockedOwnerPrefix = ownerOperationIDs.First().Item1,
                    LockedOwnerID = ownerOperationIDs.First().Item2,
                    OperationIDs = ownerOperationIDs.Select(item => item.Item3).ToArray(),
                    LockBlobFullPath = currLockFile
                };
                var blobContents = String.Join(Environment.NewLine, result.OperationIDs);
                var lockBlob = StorageSupport.CurrActiveContainer.GetBlockBlobReference(currLockFile);
                lockBlob.UploadBlobText(blobContents, false);
                return result;
            }
            return null;
        }

        public static void ExecuteMethod_ExecuteOperationsAndReleaseLock(
            LockAndExecuteInterfaceOperationsByOwner.AcquireFirstObtainableLockReturnValue
                acquireFirstObtainableLockOutput)
        {
            foreach (var operationID in acquireFirstObtainableLockOutput.OperationIDs)
            {
                try
                {
                    // TODO: execute operation as operation owner
                }
                catch (Exception exception)
                {
                    // mark operation as error and continue
                }
            }
            var lockFullName = acquireFirstObtainableLockOutput.LockBlobFullPath;
            StorageSupport.ReleaseLogicalLockByDeletingBlob(lockFullName, null);
        }
    }
}
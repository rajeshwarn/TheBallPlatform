﻿using System;
using System.Web;

namespace AaltoGlobalImpact.OIP
{
    partial class TBRegisterContainer
    {
        public static TBRegisterContainer CreateWithLoginProviders(string returnUrl, string title, string subtitle)
        {
            TBRegisterContainer registerContainer = TBRegisterContainer.CreateDefault();
            registerContainer.ReturnUrl = returnUrl;
            registerContainer.Header.Title = "Sign in";
            registerContainer.Header.SubTitle = "... or register";
            registerContainer.addLoginProviders(returnUrl);
            return registerContainer;
        }

        private void addLoginProviders(string returnUrl)
        {
            string googleRedirectUrl = getForwardingLoginUrl("https://www.google.com/accounts/o8/id", returnUrl);
            LoginProvider google = LoginProvider.CreateDefault();
            google.ProviderName = "Google";
            google.ProviderIconClass = "icon-oip-google";
            google.ProviderType = "openid";
            google.ProviderUrl = googleRedirectUrl;
            google.ReturnUrl = returnUrl;

            string yahooRedirectUrl = getForwardingLoginUrl("https://me.yahoo.com", returnUrl);
            LoginProvider yahoo = LoginProvider.CreateDefault();
            yahoo.ProviderName = "Yahoo";
            yahoo.ProviderIconClass = "icon-oip-yahoo";
            yahoo.ProviderType = "openid";
            yahoo.ProviderUrl = yahooRedirectUrl;
            yahoo.ReturnUrl = returnUrl;

            LoginProviderCollection.CollectionContent.Add(google);
            LoginProviderCollection.CollectionContent.Add(yahoo);
        }

        private string getForwardingLoginUrl(string openIDUrl, string returnUrl)
        {
            if(String.IsNullOrEmpty(returnUrl))
                return string.Format("/TheBallLogin.aspx?idProviderUrl={0}",
                                HttpUtility.UrlEncode(openIDUrl));
            return string.Format("/TheBallLogin.aspx?idProviderUrl={0}&ReturnUrl={1}",
                            HttpUtility.UrlEncode(openIDUrl), HttpUtility.UrlEncode(returnUrl));
        }
    }
}
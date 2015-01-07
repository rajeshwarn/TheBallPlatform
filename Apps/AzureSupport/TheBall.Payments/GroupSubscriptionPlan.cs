using AaltoGlobalImpact.OIP;

namespace TheBall.Payments
{
    partial class GroupSubscriptionPlan : IAdditionalFormatProvider
    {
        public object FindObjectByID(string objectId)
        {
            throw new System.NotSupportedException();
        }

        public AdditionalFormatContent[] GetAdditionalContentToStore(string masterBlobETag)
        {
            return this.GetFormattedContentToStore(masterBlobETag);
        }

        public string[] GetAdditionalFormatExtensions()
        {
            return this.GetFormatExtensions(AdditionalFormatSupport.WebUIFormatExtensions);
        }
    }
}
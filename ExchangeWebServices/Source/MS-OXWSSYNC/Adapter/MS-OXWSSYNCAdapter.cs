namespace Microsoft.Protocols.TestSuites.MS_OXWSSYNC
{
    using System;
    using System.Collections.Generic;
    using System.Xml.XPath;
    using Microsoft.Protocols.TestSuites.Common;
    using Microsoft.Protocols.TestTools;

    /// <summary>
    /// Adapter class of MS-OXWSSYNC.
    /// </summary>
    public partial class MS_OXWSSYNCAdapter : ManagedAdapterBase, IMS_OXWSSYNCAdapter
    {
        #region Fields
        /// <summary>
        /// The exchange service binding.
        /// </summary>
        private ExchangeServiceBinding exchangeServiceBinding;

        /// <summary>
        /// The endpoint url of Exchange Web Service.
        /// </summary>
        private string url;

        /// <summary>
        /// The user name used to access web service.
        /// </summary>
        private string userName;

        /// <summary>
        /// The password for userName used to access web service.
        /// </summary>
        private string password;

        /// <summary>
        /// The domain of server.
        /// </summary>
        private string domain;
        #endregion

        #region IMS_OXWSSYNCAdapter Properties
        /// <summary>
        /// Gets the raw XML request sent to protocol SUT.
        /// </summary>
        public IXPathNavigable LastRawRequestXml
        {
            get { return this.exchangeServiceBinding.LastRawRequestXml; }
        }

        /// <summary>
        /// Gets the raw XML response received from protocol SUT.
        /// </summary>
        public IXPathNavigable LastRawResponseXml
        {
            get { return this.exchangeServiceBinding.LastRawResponseXml; }
        }
        #endregion

        #region Initialize TestSuite
        /// <summary>
        /// Overrides IAdapter's Initialize() and sets default protocol short name of the testSite.
        /// </summary>
        /// <param name="testSite">Pass ITestSite to adapter, make adapter can use ITestSite's function</param>
        public override void Initialize(TestTools.ITestSite testSite)
        {
            base.Initialize(testSite);
            testSite.DefaultProtocolDocShortName = "MS-OXWSSYNC";

            // Merge configuration files.
            Common.MergeConfiguration(testSite);

            // Get the parameters from configuration files.
            this.userName = Common.GetConfigurationPropertyValue("User1Name", testSite);
            this.password = Common.GetConfigurationPropertyValue("User1Password", testSite);
            this.domain = Common.GetConfigurationPropertyValue("Domain", testSite);
            this.url = Common.GetConfigurationPropertyValue("ServiceUrl", testSite);

            this.exchangeServiceBinding = new ExchangeServiceBinding(this.url, this.userName, this.password, this.domain, testSite);
            Common.InitializeServiceBinding(this.exchangeServiceBinding, testSite);
        }
        #endregion

        #region IMS_OXWSSYNCAdapter Operations
        /// <summary>
        /// Gets synchronization information that enables folders to be synchronized 
        /// between a client and a server.
        /// </summary>
        /// <param name="request">A request to the SyncFolderHierarchy operation.</param>
        /// <returns>A response from the SyncFolderHierarchy operation.</returns>
        public SyncFolderHierarchyResponseType SyncFolderHierarchy(SyncFolderHierarchyType request)
        {
            if (request == null)
            {
                throw new ArgumentException("The SyncFolderHierarchy request should not be null.");
            }

            SyncFolderHierarchyResponseType response = this.exchangeServiceBinding.SyncFolderHierarchy(request);
            Site.Assert.IsNotNull(response, "If the operation is successful, the response should not be null.");

            this.VerifySoapVersion();
            this.VerifyTransportType();
            this.VerifySyncFolderHierarchyResponse(response, this.exchangeServiceBinding.IsSchemaValidated);
            return response;
        }

        /// <summary>
        /// Gets synchronization information that enables items to be synchronized between a client and a server.
        /// </summary>
        /// <param name="request">A request to the SyncFolderItems operation.</param>
        /// <returns>A response from the SyncFolderItems operation.</returns>
        public SyncFolderItemsResponseType SyncFolderItems(SyncFolderItemsType request)
        {
            if (request == null)
            {
                throw new ArgumentException("The SyncFolderItems request should not be null.");
            }

            SyncFolderItemsResponseType response = this.exchangeServiceBinding.SyncFolderItems(request);
            Site.Assert.IsNotNull(response, "If the operation is successful, the response should not be null.");

            this.VerifySoapVersion();
            this.VerifyTransportType();
            this.VerifySyncFolderItemsResponse(response, this.exchangeServiceBinding.IsSchemaValidated);
            return response;
        }

        /// <summary>
        /// Configure the SOAP header before calling operations.
        /// </summary>
        /// <param name="headerValues">Specify the values for SOAP header.</param>
        public void ConfigureSOAPHeader(Dictionary<string, object> headerValues)
        {
            Common.ConfigureSOAPHeader(headerValues, this.exchangeServiceBinding);
        }
        #endregion
    }
}
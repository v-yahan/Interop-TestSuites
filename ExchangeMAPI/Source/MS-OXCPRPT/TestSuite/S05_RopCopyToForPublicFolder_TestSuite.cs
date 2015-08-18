//-----------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.MS_OXCPRPT {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using Microsoft.SpecExplorer.Runtime.Testing;
    using Microsoft.Protocols.TestTools;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Spec Explorer", "3.6.100.0")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class S05_RopCopyToForPublicFolder_TestSuite : PtfTestClassBase {
        
        public S05_RopCopyToForPublicFolder_TestSuite() {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "30000");
        }
        
        #region Expect Delegates
        public delegate void CheckMAPIHTTPTransportSupportedDelegate1(bool isSupported);
        #endregion
        
        #region Event Metadata
        static System.Reflection.MethodBase CheckMAPIHTTPTransportSupportedInfo = TestManagerHelpers.GetMethodInfo(typeof(Microsoft.Protocols.TestSuites.MS_OXCPRPT.IMS_OXCPRPTAdapter), "CheckMAPIHTTPTransportSupported", typeof(bool).MakeByRefType());
        #endregion
        
        #region Adapter Instances
        private Microsoft.Protocols.TestSuites.MS_OXCPRPT.IMS_OXCPRPTAdapter IMS_OXCPRPTAdapterInstance;
        #endregion
        
        #region Class Initialization and Cleanup
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void ClassInitialize(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext context) {
            PtfTestClassBase.Initialize(context);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void ClassCleanup() {
            PtfTestClassBase.Cleanup();
        }
        #endregion
        
        #region Test Initialization and Cleanup
        protected override void TestInitialize() {
            this.InitializeTestManager();
            this.IMS_OXCPRPTAdapterInstance = ((Microsoft.Protocols.TestSuites.MS_OXCPRPT.IMS_OXCPRPTAdapter)(this.Manager.GetAdapter(typeof(Microsoft.Protocols.TestSuites.MS_OXCPRPT.IMS_OXCPRPTAdapter))));
        }
        
        protected override void TestCleanup() {
            base.TestCleanup();
            this.CleanupTestManager();
        }
        #endregion
        
        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void MSOXCPRPT_S05_RopCopyToForPublicFolder_TestSuite() {
            this.Manager.BeginTest("MSOXCPRPT_S05_RopCopyToForPublicFolder_TestSuite");
            this.Manager.Comment("reaching state \'S0\'");
            bool temp0;
            this.Manager.Comment("executing step \'call CheckMAPIHTTPTransportSupported(out _)\'");
            this.IMS_OXCPRPTAdapterInstance.CheckMAPIHTTPTransportSupported(out temp0);
            this.Manager.AddReturn(CheckMAPIHTTPTransportSupportedInfo, null, temp0);
            this.Manager.Comment("reaching state \'S1\'");
            int temp1 = this.Manager.ExpectReturn(this.QuiescenceTimeout, true, new ExpectedReturn(S05_RopCopyToForPublicFolder_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCPRPT_S05_RopCopyToForPublicFolder_TestSuiteCheckMAPIHTTPTransportSupportedChecker)), new ExpectedReturn(S05_RopCopyToForPublicFolder_TestSuite.CheckMAPIHTTPTransportSupportedInfo, null, new CheckMAPIHTTPTransportSupportedDelegate1(this.MSOXCPRPT_S05_RopCopyToForPublicFolder_TestSuiteCheckMAPIHTTPTransportSupportedChecker1)));
            if ((temp1 == 0)) {
                this.Manager.Comment("reaching state \'S2\'");
                this.Manager.Comment("executing step \'call InitializePublicFolder()\'");
                this.IMS_OXCPRPTAdapterInstance.InitializePublicFolder();
                this.Manager.Comment("reaching state \'S4\'");
                this.Manager.Comment("checking step \'return InitializePublicFolder\'");
                this.Manager.Comment("reaching state \'S5\'");
                this.Manager.Comment("executing step \'call RopCopyToForPublicFolder()\'");
                this.IMS_OXCPRPTAdapterInstance.RopCopyToForPublicFolder();
                this.Manager.Comment("reaching state \'S6\'");
                this.Manager.Comment("checking step \'return RopCopyToForPublicFolder\'");
                this.Manager.Comment("reaching state \'S7\'");
                goto label0;
            }
            if ((temp1 == 1)) {
                this.Manager.Comment("reaching state \'S3\'");
                goto label0;
            }
            throw new InvalidOperationException("never reached");
        label0:
;
            this.Manager.EndTest();
        }
        
        private void MSOXCPRPT_S05_RopCopyToForPublicFolder_TestSuiteCheckMAPIHTTPTransportSupportedChecker(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S1");
        }
        
        private void MSOXCPRPT_S05_RopCopyToForPublicFolder_TestSuiteCheckMAPIHTTPTransportSupportedChecker1(bool isSupported) {
            this.Manager.Comment("checking step \'return CheckMAPIHTTPTransportSupported/[out False]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSupported, "isSupported of CheckMAPIHTTPTransportSupported, state S1");
        }
        #endregion
    }
}
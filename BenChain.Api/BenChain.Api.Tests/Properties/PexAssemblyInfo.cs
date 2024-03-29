// <copyright file="PexAssemblyInfo.cs">Copyright ©  2019</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("BenChain.Api")]
[assembly: PexInstrumentAssembly("System.Configuration")]
[assembly: PexInstrumentAssembly("System.Web.Http.WebHost")]
[assembly: PexInstrumentAssembly("Nethereum.ABI")]
[assembly: PexInstrumentAssembly("Nethereum.Contracts")]
[assembly: PexInstrumentAssembly("System.Numerics")]
[assembly: PexInstrumentAssembly("Newtonsoft.Json")]
[assembly: PexInstrumentAssembly("Microsoft.Rest.ClientRuntime")]
[assembly: PexInstrumentAssembly("Swashbuckle.AutoRestExtensions")]
[assembly: PexInstrumentAssembly("Common.Logging.Core")]
[assembly: PexInstrumentAssembly("NBitcoin")]
[assembly: PexInstrumentAssembly("Nethereum.Accounts")]
[assembly: PexInstrumentAssembly("System.Net.Http.Formatting")]
[assembly: PexInstrumentAssembly("System.Net.Http")]
[assembly: PexInstrumentAssembly("System.Web.Http")]
[assembly: PexInstrumentAssembly("WebActivatorEx")]
[assembly: PexInstrumentAssembly("Swashbuckle.Core")]
[assembly: PexInstrumentAssembly("System.Web")]
[assembly: PexInstrumentAssembly("Nethereum.Web3")]
[assembly: PexInstrumentAssembly("BenChainClient.Api")]
[assembly: PexInstrumentAssembly("Nethereum.Hex")]
[assembly: PexInstrumentAssembly("Nethereum.RPC")]
[assembly: PexInstrumentAssembly("Nethereum.HdWallet")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Configuration")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Web.Http.WebHost")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Nethereum.ABI")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Nethereum.Contracts")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Numerics")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Newtonsoft.Json")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.Rest.ClientRuntime")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Swashbuckle.AutoRestExtensions")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Common.Logging.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "NBitcoin")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Nethereum.Accounts")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Net.Http.Formatting")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Net.Http")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Web.Http")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "WebActivatorEx")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Swashbuckle.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Web")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Nethereum.Web3")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "BenChainClient.Api")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Nethereum.Hex")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Nethereum.RPC")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Nethereum.HdWallet")]


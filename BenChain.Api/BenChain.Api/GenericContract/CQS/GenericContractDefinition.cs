using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace BenChain.Api.GenericContract.CQS
{


    public partial class GenericContractDeployment : GenericContractDeploymentBase
    {
        public GenericContractDeployment() : base(BYTECODE) { }
        public GenericContractDeployment(string byteCode) : base(byteCode) { }
    }

    public class GenericContractDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405234801561001057600080fd5b506040516105993803806105998339810160409081528151602080840151928401516060850151608086015160a087015160008054600160a060020a031916600160a060020a0388161790556001879055928701805195979095928101949101929161008291600391908701906100d3565b5082516100969060059060208601906100d3565b5081516100aa9060069060208501906100d3565b5060075550504260025550506008805461010060a860020a03191633610100021790555061016e565b828054600181600116156101000203166002900490600052602060002090601f016020900481019282601f1061011457805160ff1916838001178555610141565b82800160010185558215610141579182015b82811115610141578251825591602001919060010190610126565b5061014d929150610151565b5090565b61016b91905b8082111561014d5760008155600101610157565b90565b61041c8061017d6000396000f3006080604052600436106100825763ffffffff7c01000000000000000000000000000000000000000000000000000000006000350416630ee2cb10811461008757806312424e3f146100c557806321df0da7146100dc5780634b8f9866146101035780634e69d5601461015c5780637cd87ba214610171578063ab04010714610186575b600080fd5b34801561009357600080fd5b5061009c61019b565b6040805173ffffffffffffffffffffffffffffffffffffffff9092168252519081900360200190f35b3480156100d157600080fd5b506100da6101bd565b005b3480156100e857600080fd5b506100f16102d7565b60408051918252519081900360200190f35b34801561010f57600080fd5b506040805160206004803580820135601f81018490048402850184019095528484526100da9436949293602493928401919081908401838280828437509497506102dd9650505050505050565b34801561016857600080fd5b506100f1610326565b34801561017d57600080fd5b506100f161033f565b34801561019257600080fd5b506100da610345565b600854610100900473ffffffffffffffffffffffffffffffffffffffff165b90565b600880546000919060ff19166001835b02179055506009805473ffffffffffffffffffffffffffffffffffffffff1916331790556008547f1ec2a066378131aed145cdce681972fee97ef9f21fda9d2de354c948d2b32de490309060059060ff16600181111561022957fe5b6040805173ffffffffffffffffffffffffffffffffffffffff85168152908101829052606060208201818152845460026000196101006001841615020190911604918301829052906080830190859080156102c55780601f1061029a576101008083540402835291602001916102c5565b820191906000526020600020905b8154815290600101906020018083116102a857829003601f168201915b505094505050505060405180910390a1565b60015490565b60048054600181018083556000929092528251610321917f8a35acfbc15ff81a39ae7d344fd709f28e8600b4aa8c65c6b64bfe7fe36bd19b01906020850190610358565b505050565b60085460009060ff16600181111561033a57fe5b905090565b60025490565b600880546001919060ff191682806101cd565b828054600181600116156101000203166002900490600052602060002090601f016020900481019282601f1061039957805160ff19168380011785556103c6565b828001600101855582156103c6579182015b828111156103c65782518255916020019190600101906103ab565b506103d29291506103d6565b5090565b6101ba91905b808211156103d257600081556001016103dc5600a165627a7a723058207b7fdf8fa0a92cc240179efedaa723ff36e1a5c0e9e472ea4f220f1e9391635c0029";
        public GenericContractDeploymentBase() : base(BYTECODE) { }
        public GenericContractDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_parent", 1)]
        public virtual string Parent { get; set; }
        [Parameter("bytes32", "_token", 2)]
        public virtual byte[] Token { get; set; }
        [Parameter("string", "_contextHash", 3)]
        public virtual string ContextHash { get; set; }
        [Parameter("string", "_contextId", 4)]
        public virtual string ContextId { get; set; }
        [Parameter("string", "_version", 5)]
        public virtual string Version { get; set; }
        [Parameter("uint256", "_endDate", 6)]
        public virtual BigInteger EndDate { get; set; }
    }

    public partial class GetCreatorFunction : GetCreatorFunctionBase { }

    [Function("getCreator", "address")]
    public class GetCreatorFunctionBase : FunctionMessage
    {

    }

    public partial class ApproveFunction : ApproveFunctionBase { }

    [Function("approve")]
    public class ApproveFunctionBase : FunctionMessage
    {

    }

    public partial class GetTokenFunction : GetTokenFunctionBase { }

    [Function("getToken", "bytes32")]
    public class GetTokenFunctionBase : FunctionMessage
    {

    }

    public partial class AddAttachmentHashFunction : AddAttachmentHashFunctionBase { }

    [Function("addAttachmentHash")]
    public class AddAttachmentHashFunctionBase : FunctionMessage
    {
        [Parameter("string", "hash", 1)]
        public virtual string Hash { get; set; }
    }

    public partial class GetStatusFunction : GetStatusFunctionBase { }

    [Function("getStatus", "uint256")]
    public class GetStatusFunctionBase : FunctionMessage
    {

    }

    public partial class GetCreateDateFunction : GetCreateDateFunctionBase { }

    [Function("getCreateDate", "uint256")]
    public class GetCreateDateFunctionBase : FunctionMessage
    {

    }

    public partial class DeclineFunction : DeclineFunctionBase { }

    [Function("decline")]
    public class DeclineFunctionBase : FunctionMessage
    {

    }

    public partial class StatusIsChangedEventDTO : StatusIsChangedEventDTOBase { }

    [Event("StatusIsChanged")]
    public class StatusIsChangedEventDTOBase : IEventDTO
    {
        [Parameter("address", "contractId", 1, false )]
        public virtual string ContractId { get; set; }
        [Parameter("string", "contextId", 2, false )]
        public virtual string ContextId { get; set; }
        [Parameter("uint256", "status", 3, false )]
        public virtual BigInteger Status { get; set; }
    }

    public partial class GetCreatorOutputDTO : GetCreatorOutputDTOBase { }

    [FunctionOutput]
    public class GetCreatorOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class GetTokenOutputDTO : GetTokenOutputDTOBase { }

    [FunctionOutput]
    public class GetTokenOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }



    public partial class GetStatusOutputDTO : GetStatusOutputDTOBase { }

    [FunctionOutput]
    public class GetStatusOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetCreateDateOutputDTO : GetCreateDateOutputDTOBase { }

    [FunctionOutput]
    public class GetCreateDateOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }


}

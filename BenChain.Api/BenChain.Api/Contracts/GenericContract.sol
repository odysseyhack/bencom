pragma solidity ^0.4.24;

contract GenericContract {
    address parent;
    bytes32 token;
    uint createDate;

    enum Status {approved, declined}

    string contextId;
    string version;
    uint endDate;
    string[] attachments;
    Status status;
    
    address creator;
    address owner;
    
    event StatusIsChanged(
        address contractId,
        string contextId,
        uint status
    );

    constructor (
        address _parent,
        bytes32 _token,
        string memory _contextId,
        string memory _version,
        uint _endDate
    ) public {
        parent = _parent;
        token = _token;
        
        contextId = _contextId;
        version = _version;
        endDate = _endDate;
        
        createDate = now;
        creator = msg.sender;
    }
    
    modifier beforeEndDate {
        require(createDate < endDate);
        _;
    }
    
    function addAttachmentHash(string hash) beforeEndDate public {
        require(msg.sender == creator, "Can not add attachment hash, you are not the owner of the contract");
        attachments.push(hash);
    }
    
    function approve(string token1, string token2) beforeEndDate public {
        if (msg.sender != owner) {
            require(keccak256(abi.encodePacked(token1, token2)) == token, "Invalid token");
        }
        
        status = Status.approved;
        
        emit StatusIsChanged(address(this), contextId, uint(status));
    }
    
    function decline(string token1, string token2) beforeEndDate public {
        if (msg.sender != owner) {
            require(keccak256(abi.encodePacked(token1, token2)) == token, "Invalid token");
        }
        
        status = Status.declined;
        
        emit StatusIsChanged(address(this), contextId, uint(status));
    }
    
    function getStatus() public view returns(uint) {
        return uint(status);
    }
    
    function getToken() public view returns(bytes32) {
        return token;
    }
    
    function getCreator() public view returns(address) {
        return creator;
    }
    
    function getCreateDate() public view returns(uint) {
        return createDate;
    }
}
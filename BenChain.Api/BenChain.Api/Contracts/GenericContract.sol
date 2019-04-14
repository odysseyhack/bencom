pragma solidity ^0.4.24;

contract GenericContract {
    address parent;
    bytes32 token;
    uint createDate;
    
    string contextHash;
    string[] attachments;

    enum Status {approved, declined}

    string contextId;
    string version;
    uint endDate;
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
        string _contextHash,
        string memory _contextId,
        string memory _version,
        uint _endDate
    ) public {
        parent = _parent;
        token = _token;
        
        contextHash = _contextHash;
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
    
    function addAttachmentHash(string hash) public {
        attachments.push(hash);
    }
    
    function approve() public {
        status = Status.approved;
        owner = msg.sender;
        
        emit StatusIsChanged(address(this), contextId, uint(status));
    }
    
    function decline() public {
        status = Status.declined;
        owner = msg.sender;
        
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
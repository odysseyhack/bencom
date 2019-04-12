pragma solidity ^0.5.6;

contract GenericContract {
	address parent;
	bytes32 token;
	uint createdDate;

	string contextId;
	string version;
	uint endDate;
	//string[] attachments; // todo goede lijst van maken
	string status; // todo enum
	
	address owner;
	
	event StatusIsChanged(
	    address contractId,
	    string contextId,
	    string status
	);

	constructor (
		address _parent,
		string memory _token,
		string memory _contextId,
		string memory _version,
		uint _endDate
		//bytes32[] _attachments
	) public {
		parent = _parent;
		token = keccak256(abi.encodePacked(_token));
		createdDate = now;

		contextId = _contextId;
		version = _version;
		endDate = _endDate;
		//attachments = _attachments;
	}
	
	function approve() public {
		status = "Approved";
		
		emit StatusIsChanged(address(this), contextId, status);
	}
	
	function decline() public {
	    status = "Declined";
	    
	    emit StatusIsChanged(address(this), contextId, status);
	}
}
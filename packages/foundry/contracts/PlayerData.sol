//SPDX-License-Identifier: MIT
pragma solidity >=0.8.0 <0.9.0;

contract PlayerData {
    mapping(address user => uint256) s_partyMemberStrength;
    mapping(address user => uint256) s_partyMemberSpeed;
    mapping(address user => uint256) s_playerStrength;
    mapping(address user => uint256) s_playerStage;
    mapping(address user => uint256) s_playerGold;

    function setPartyMemberStrength(uint256 number) external {
        s_partyMemberStrength[msg.sender] = number;
    }

    function setPartyMemberSpeed(uint256 number) external {
        s_partyMemberSpeed[msg.sender] = number;
    }

    function setPlayerStrength(uint256 number) external {
        s_playerStrength[msg.sender] = number;
    }

    function setPlayerStage(uint256 number) external {
        s_playerStage[msg.sender] = number;
    }

    function setPlayerGold(uint256 number) external {
        s_playerGold[msg.sender] = number;
    }

    function getPartyMemberStrength(
        address user
    ) external view returns (uint256) {
        return s_partyMemberStrength[user];
    }

    function getPartyMemberSpeed(address user) external view returns (uint256) {
        return s_partyMemberSpeed[user];
    }

    function getPlayerStrength(address user) external view returns (uint256) {
        return s_playerStrength[user];
    }

    function getPlayerStage(address user) external view returns (uint256) {
        return s_playerStage[user];
    }

    function getPlayerGold(address user) external view returns (uint256) {
        return s_playerStage[user];
    }
}

//SPDX-License-Identifier: MIT
pragma solidity >=0.8.0 <0.9.0;

// Useful for debugging. Remove when deploying to a live network.
import "forge-std/console.sol";

contract YourContract {
    uint256 s_test = 50;

    function getTest() external view returns (uint256) {
        return s_test;
    }

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
        s_playerStage[msg.sender] = number;
    }

    function getPartyMemberStrength() external view returns (uint256) {
        return s_partyMemberStrength[msg.sender];
    }

    function getPartyMemberSpeed() external view returns (uint256) {
        return s_partyMemberSpeed[msg.sender];
    }

    function getPlayerStrength() external view returns (uint256) {
        return s_playerStrength[msg.sender];
    }

    function getPlayerStage() external view returns (uint256) {
        return s_playerStage[msg.sender];
    }

    function getPlayerGold() external view returns (uint256) {
        return s_playerStage[msg.sender];
    }
}

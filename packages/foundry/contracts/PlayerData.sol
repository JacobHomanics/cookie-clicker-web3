//SPDX-License-Identifier: MIT
pragma solidity >=0.8.0 <0.9.0;

contract PlayerData {
    // struct Stats {
    //     uint256 partyMemberStrength;
    //     uint256 partyMemberSpeed;
    //     uint256 playerStrength;
    //     uint256 playerStage;
    //     uint256 playerGold;
    // }

    // mapping(address user => Stats) stats;

    // function setStats(Stats memory newStats) external {
    //     stats[msg.sender] = newStats;
    // }

    // function getStats(address user) external view returns (Stats memory) {
    //     return stats[user];
    // }

    mapping(address user => uint256) s_partyMemberStrength;
    mapping(address user => uint256) s_partyMemberSpeed;
    mapping(address user => uint256) s_playerStrength;
    mapping(address user => uint256) s_playerStage;
    mapping(address user => uint256) s_playerGold;

    //for better security, gold can be tracked in a seperate smart contract, and only an authorized user can call the function.
    function setPartyMemberStrength(
        uint256 goldAmount,
        uint256 number
    ) external {
        s_playerGold[msg.sender] = goldAmount;
        s_partyMemberStrength[msg.sender] = number;
    }

    function setPartyMemberSpeed(uint256 goldAmount, uint256 number) external {
        s_playerGold[msg.sender] = goldAmount;
        s_partyMemberSpeed[msg.sender] = number;
    }

    function setPlayerStrength(uint256 goldAmount, uint256 number) external {
        s_playerGold[msg.sender] = goldAmount;
        s_playerStrength[msg.sender] = number;
    }

    function setPlayerStage(uint256 goldAmount, uint256 number) external {
        s_playerGold[msg.sender] = goldAmount;
        s_playerStage[msg.sender] = number;
    }

    function setPlayerGold(uint256 goldAmount) external {
        s_playerGold[msg.sender] = goldAmount;
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
        return s_playerGold[user];
    }
}

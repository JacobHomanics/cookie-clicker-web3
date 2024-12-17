//SPDX-License-Identifier: MIT
pragma solidity ^0.8.19;

import "../contracts/PlayerData.sol";
import "./DeployHelpers.s.sol";

contract DeployYourContract is ScaffoldETHDeploy {
    // use `deployer` from `ScaffoldETHDeploy`
    function run() external ScaffoldEthDeployerRunner {
        PlayerData yourContract = new PlayerData();
        console.logString(
            string.concat(
                "YourContract deployed at: ",
                vm.toString(address(yourContract))
            )
        );
    }
}

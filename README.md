# Cookie Clicker - Web3

A cookie clicker video game which utilizes the blockchain to store the game state.

[Demo](https://cookie-clicker-web3-nextjs.vercel.app/)

# Dependencies

Unity

- Unity 6000.0.31f1

- ThirdWeb Unity SDK v5.12.1

NextJS

- [Node (>= v18.18)](https://nodejs.org/en/download/)
- Yarn ([v1](https://classic.yarnpkg.com/en/docs/install/) or [v2+](https://yarnpkg.com/getting-started/install))
- [Git](https://git-scm.com/downloads)

Foundry

- forge 0.2.0 (206dab2 2024-12-17T00:23:06.813628000Z)

# Quickstart

```
git clone https://github.com/JacobHomanics/cookie-clicker-web3.git
```

## Unity

The unity project is ready to go. You can play the game in the editor, however you will not be able to use Web3 functionality. To use Web3 functionality, create WebGL build and open it in a browser and you will be able to play the game and connect a wallet to save your progress.

## Foundry/NextJS

The Solidity/NextJS portion of the code is a boilerplate [Scaffold-ETH 2](https://github.com/scaffold-eth/scaffold-eth-2) project.

Please follow its instructions in order to work with the appropriate code.

# Onchain-Integration

This project uses SE-2 to test and deploy smart contracts to EVM-compatible local chains, testnets, or mainnets. Also provided is a handy frontend where you can interact with and debug the smart contracts, and play the latest build of the video game!

The video game itself uses Thirdweb Unity SDK to connect to the blockchain. The game is currently configured to interact with Base Mainnet. It allows the user to connect a wallet to Base Mainnet. It can also read the player's Gold, Stage, Strength, Teammate Strength, and Teammate Speed from the PlayerData smart contract. Finally, it also allows for the user to send their player's data and the game state to the smart contract and update the appropriate mappings to be used for future use. The blockchain is like a decentralized database!

The PlayerData smart contract contains a mapping for each of the aforementioned stats that is linked to the player's connected wallet.

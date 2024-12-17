using UnityEngine;
using UnityEngine.Events;
using Thirdweb.Unity;
using Thirdweb;

public class NumberLoaderAll : MonoBehaviour
{
    public ConnectWalletWeb3 cww3;
    public string functionName;

    public UnityEvent<float> OnLoad;

    public Number playerStrength;
    public Number playerStage;
    public Number partyStrength;
    public Number partySpeed;
    public Number playerGold;

    public class Stats
    {
        public int partyMemberStrength;
        public int partyMemberSpeed;
        public int playerStrength;
        public int playerStage;
        public int playerGold;
    }
#pragma warning disable CS1998
    public async void Connect()
    {
        var contract = await ThirdwebManager.Instance.GetContract(
                 address: cww3.contractAddress,
                 chainId: cww3.chainId,
                 abi: "[{\"inputs\":[{\"internalType\":\"address\",\"name\":\"user\",\"type\":\"address\"}],\"name\":\"getStats\",\"outputs\":[{\"components\":[{\"internalType\":\"uint256\",\"name\":\"partyMemberStrength\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"partyMemberSpeed\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerStrength\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerStage\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerGold\",\"type\":\"uint256\"}],\"internalType\":\"struct PlayerData.Stats\",\"name\":\"\",\"type\":\"tuple\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"uint256\",\"name\":\"partyMemberStrength\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"partyMemberSpeed\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerStrength\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerStage\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerGold\",\"type\":\"uint256\"}],\"name\":\"setStats\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"}]"
             );

        Stats result = await contract.Read<Stats>("getStats", cww3.address);

        partyStrength.Value = result.partyMemberStrength;
        partySpeed.Value = result.partyMemberSpeed;
        playerStrength.Value = result.playerStrength;
        playerStage.Value = result.playerStage;
        playerGold.Value = result.playerGold;

        Debug.Log("Loaded");
        // OnLoad?.Invoke(result);

        // #if UNITY_EDITOR

        // #elif UNITY_WEBGL
        //         var contract = await ThirdwebManager.Instance.GetContract(
        //                  address: cww3.contractAddress,
        //                  chainId: cww3.chainId,
        //                  abi: "[{\"inputs\":[{\"internalType\":\"address\",\"name\":\"user\",\"type\":\"address\"}],\"name\":\"getStats\",\"outputs\":[{\"components\":[{\"internalType\":\"uint256\",\"name\":\"partyMemberStrength\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"partyMemberSpeed\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerStrength\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerStage\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerGold\",\"type\":\"uint256\"}],\"internalType\":\"struct PlayerData.Stats\",\"name\":\"\",\"type\":\"tuple\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"uint256\",\"name\":\"partyMemberStrength\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"partyMemberSpeed\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerStrength\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerStage\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerGold\",\"type\":\"uint256\"}],\"name\":\"setStats\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"}]"
        //              );

        //         var result = await contract.Read<int, int, int, int, int>("getStats", cww3.address);

        //         const [value1, value2, value3, value4, value5] = result;

        //         partyStrength.Value = value1;
        //         partySpeed.Value = value2;
        //         playerStrength.Value = value3;
        //         playerStage.Value = value4;
        //         playerGold.Value = value5;

        //         Debug.Log("Loaded");
        //         OnLoad?.Invoke(result);
        // #endif
    }
#pragma warning restore CS1998

}

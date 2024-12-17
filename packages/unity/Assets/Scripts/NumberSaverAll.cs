using UnityEngine;
using Thirdweb.Unity;
using Thirdweb;
using UnityEngine.Events;

public class NumberSaverAll : MonoBehaviour
{
    public class Stats
    {
        public float partyMemberStrength;
        public float partyMemberSpeed;
        public float playerStrength;
        public float playerStage;
        public float playerGold;
    }


    public ConnectWalletWeb3 cww3;
    public string functionName;
    public Number number;

    public UnityEvent OnSave;

    public Number partyMemberStrength;
    public Number partyMemberSpeed;
    public Number playerStrength;
    public Number playerStage;
    public Number playerGold;

#pragma warning disable CS1998
    public async void Connect()
    {
        var stats = new Stats
        {
            partyMemberSpeed = partyMemberSpeed.Value,
            partyMemberStrength = partyMemberStrength.Value,
            playerStrength = playerStrength.Value,
            playerStage = playerStage.Value,
            playerGold = playerGold.Value
        };


#if UNITY_EDITOR

#elif UNITY_WEBGL
        var contract = await ThirdwebManager.Instance.GetContract(
                 address: cww3.contractAddress,
                 chainId: cww3.chainId,
                 abi: "[{\"inputs\":[{\"internalType\":\"address\",\"name\":\"user\",\"type\":\"address\"}],\"name\":\"getStats\",\"outputs\":[{\"components\":[{\"internalType\":\"uint256\",\"name\":\"partyMemberStrength\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"partyMemberSpeed\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerStrength\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerStage\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerGold\",\"type\":\"uint256\"}],\"internalType\":\"struct PlayerData.Stats\",\"name\":\"\",\"type\":\"tuple\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"components\":[{\"internalType\":\"uint256\",\"name\":\"partyMemberStrength\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"partyMemberSpeed\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerStrength\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerStage\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"playerGold\",\"type\":\"uint256\"}],\"internalType\":\"struct PlayerData.Stats\",\"name\":\"newStats\",\"type\":\"tuple\"}],\"name\":\"setStats\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"}]"

             );

        await contract.Write(ThirdwebManager.Instance.GetActiveWallet(), functionName, 0, stats);
#endif

        Debug.Log("Saved");
        OnSave?.Invoke();

    }
#pragma warning restore CS1998

}

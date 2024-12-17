using Thirdweb;
using Thirdweb.Unity;
using TMPro;
using UnityEngine;

public class ConnectWalletWeb3 : MonoBehaviour
{
    public int chainId;
    public string contractAddress;

    public GameObject loginButton;
    public GameObject addressTextGo;
    public TMP_Text addressText;

    public string address;

    public async void Connect()
    {
#if UNITY_EDITOR
        var walletOptions = new WalletOptions(WalletProvider.PrivateKeyWallet, chainId);
        var wallet = await ThirdwebManager.Instance.ConnectWallet(walletOptions);
        address = await wallet.GetAddress();
#elif UNITY_WEBGL
    var walletOptions = new WalletOptions(WalletProvider.MetaMaskWallet, chainId);
        var wallet = await ThirdwebManager.Instance.ConnectWallet(walletOptions);
        address = await wallet.GetAddress();
#endif

        var contract = await ThirdwebManager.Instance.GetContract(
            address: contractAddress,
            chainId: chainId,
            abi: "[{\"inputs\":[],\"name\":\"getPartyMemberSpeed\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"getPartyMemberStrength\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"getPlayerGold\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"getPlayerStage\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"getPlayerStrength\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"getTest\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"uint256\",\"name\":\"number\",\"type\":\"uint256\"}],\"name\":\"setPartyMemberSpeed\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"uint256\",\"name\":\"number\",\"type\":\"uint256\"}],\"name\":\"setPartyMemberStrength\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"uint256\",\"name\":\"number\",\"type\":\"uint256\"}],\"name\":\"setPlayerGold\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"uint256\",\"name\":\"number\",\"type\":\"uint256\"}],\"name\":\"setPlayerStage\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"uint256\",\"name\":\"number\",\"type\":\"uint256\"}],\"name\":\"setPlayerStrength\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"}]"
        );

        var result = await contract.Read<int>("getTest");
        Debug.Log(result);
    }

    void Update()
    {
        loginButton.SetActive(address.Length <= 0);
        addressTextGo.SetActive(address.Length > 0);


        if (address.Length > 0)
        {
            string shortenedAddress = address?.Substring(0, 6) + "..." + address?.Substring(address.Length - 4);

            addressText.text = shortenedAddress;
        }

    }
}

using Thirdweb.Unity;
using UnityEngine;

public class ConnectWalletBtn : MonoBehaviour
{
    public async void Connect()
    {
        var options = new WalletOptions(provider: WalletProvider.MetaMaskWallet, chainId: 1);
        var wallet = await ThirdwebManager.Instance.ConnectWallet(options);

        Debug.Log("I ran");
    }
}

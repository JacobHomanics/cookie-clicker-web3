using Thirdweb;
using Thirdweb.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ConnectWalletWeb3 : MonoBehaviour
{
    public int chainId;
    public string contractAddress;

    public GameObject loginButton;
    public GameObject addressTextGo;
    public TMP_Text addressText;

    public string address;

    public UnityEvent OnConnectWallet;

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

        OnConnectWallet?.Invoke();
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

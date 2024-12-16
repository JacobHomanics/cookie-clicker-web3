using UnityEngine;
using Thirdweb.Unity;
using Thirdweb;

public class SmartContractDataController : MonoBehaviour
{
    public async void ReadContract()
    {
        var contract = await ThirdwebManager.Instance.GetContract(
         address: "contract-address",
         chainId: 8453,
         abi: "optional-abi"
     );

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements; // namespace to get advertisment class

public class UnityAdsSample : MonoBehaviour
{
    public static bool showAds = true;
    private string gameID = "";
    private bool testMode = true; // for debugging ads you would need to keep true until publishing
    
    
    // Start is called before the first frame update
    void Start()
    {
        //we need to initialize the ads
        if (!Advertisement.isInitialized)
        {
            Advertisement.Initialize(gameID, testMode);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

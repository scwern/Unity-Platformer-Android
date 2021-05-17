using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdMobAwake : MonoBehaviour
{
    private InterstitialAd ads;
    private const string ad = "ca-app-pub-5480376578434100/1764675482";

    // Start is called before the first frame update
    
    private void OnEnable()
    {
        ads = new InterstitialAd(ad);
        AdRequest adRequest = new AdRequest.Builder().Build();
        ads.LoadAd(adRequest);
    }
    public void ShowAd()
    {
        if (ads.IsLoaded())
        {
            ads.Show();
            Time.timeScale = 0f;
        }
    }
}

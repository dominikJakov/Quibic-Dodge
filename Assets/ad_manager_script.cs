using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;


public class ad_manager_script : MonoBehaviour {

    private int broj = 0;

    public void ShowAdVideo()
    {


        broj = Random.Range(0, 3);


        if (broj == 2)
        {

            if (Advertisement.IsReady())
            {
                Advertisement.Show("video");

            }
        }

    }

    public void ShowAdRewardVideo()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo");

        }

    }

    public void ShowAdShopRewardVideo()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo", new ShowOptions() { resultCallback = HandleAdResults });
            

        }

    }

    private void HandleAdResults(ShowResult result)
    {
        switch (result)
        {

            case ShowResult.Finished:
                PlayerPrefs.SetFloat("Money", 2f + PlayerPrefs.GetFloat("Money", 0));
                FindObjectOfType<points_script>().GetComponent<points_script>().show();
                SceneManager.LoadScene("store");
                // FindObjectOfType<game_store_manager>().GetComponent<game_store_manager>().restart_points();
                break;
            case ShowResult.Skipped:
                Debug.Log("skipo");
                break;
            case ShowResult.Failed:
                Debug.Log("nije uspio");
                break;
        }


    }

}

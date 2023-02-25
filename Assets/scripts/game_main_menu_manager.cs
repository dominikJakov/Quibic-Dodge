using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_main_menu_manager : MonoBehaviour {

	// Use this for initialization
	public void start_game () {
        SceneManager.LoadScene("gamescene");
    }

    public void open_store()
    {
        SceneManager.LoadScene("store");
    }

    public void end_game()
    {
        Application.Quit();
    }

    public void mute_speaker()
    {
        if (PlayerPrefs.GetInt("mute_volume", 0) == 1)
        {
            PlayerPrefs.SetInt("mute_volume", 0);

            FindObjectOfType<mute_script>().GetComponent<mute_script>().change_sprite();
        }
        else
        {

            PlayerPrefs.SetInt("mute_volume", 1);

            FindObjectOfType<mute_script>().GetComponent<mute_script>().change_sprite();
        }
    }
}

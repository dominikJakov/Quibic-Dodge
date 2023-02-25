using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public float money = 0f;
    public GameObject game_over_menu;
    public GameObject player_movement_button;
    public GameObject continue_button;
    public GameObject player;
    public GameObject arrow_position;
    public GameObject exclamation_mark;
    public GameObject New_highscore;

    AudioSource audioSource;
    public AudioClip background_music;

    private bool one_show = false;
    public bool besmrtan = false;
    public bool oduzimanje_vremena = false;
    public bool continue_taken = false;
    private bool pocni_timer_za_continue = false;
    public int continue_timer = 120;
    private int timer = 120;
    public float scaler_arrow_position = 1f;

    private float min_money = 10f;
    private bool vidio = true;

    public bool mute_speaker = false;
    public int mute_speaker_on_off = 1;


    void Start()
    {
        mute_speaker_on_off = PlayerPrefs.GetInt("mute_volume", 0);
        if (mute_speaker_on_off == 1)
        {
            mute_speaker = false;
        }
        else
        {
            mute_speaker = true;
        }
        Debug.Log(mute_speaker);
        audioSource = GetComponent<AudioSource>();
        if (mute_speaker == true)
        {
            audioSource.Pause();
        }

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Open_Main_menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Open_Store()
    {
        SceneManager.LoadScene("store");
        vidio = false;
        exclamation_mark.SetActive(false);
    }


    // Use this for initialization
    public void GameOver() {
        if (besmrtan == false)
        {
            if (continue_taken == false)
            {
             
                FindObjectOfType<game_parent_moving>().GetComponent<game_parent_moving>().speed = 0f;
                FindObjectOfType<spawn_enemy>().GetComponent<spawn_enemy>().spawn_enemys = false;
                FindObjectOfType<score_script>().GetComponent<score_script>().razlika_vremena();
                FindObjectOfType<enemy_movement>().GetComponent<enemy_movement>().speed = 0f;
                
                FindObjectOfType<player_movement>().GetComponent<player_movement>().speed = 0f;
                FindObjectOfType<score_script>().GetComponent<score_script>().stop_working = true;
                continue_button.SetActive(true);
                player_movement_button.SetActive(false);
                continue_taken = true;
                one_show = true;
                pocni_timer_za_continue = true;
                FindObjectOfType<slider_continue_script>().GetComponent<slider_continue_script>().pokrenuti = true;
                audioSource.Pause();


            }
            else
            { 
                if (one_show == false)
                {
                    if (oduzimanje_vremena == false)
                    {
                        FindObjectOfType<score_script>().GetComponent<score_script>().kraj_razlika_vremena();
                    }
                    
                    PlayerPrefs.SetFloat("Money", (Time.timeSinceLevelLoad - FindObjectOfType<score_script>().GetComponent<score_script>().score_mem) + PlayerPrefs.GetFloat("Money", 0));
                    money = PlayerPrefs.GetFloat("Money", 0);


                    game_over_menu.SetActive(true);
                    player_movement_button.SetActive(false);
                    continue_button.SetActive(false);
                    FindObjectOfType<game_parent_moving>().GetComponent<game_parent_moving>().speed = 0f;
                    FindObjectOfType<spawn_enemy>().GetComponent<spawn_enemy>().spawn_enemys = false;
                    FindObjectOfType<enemy_movement>().GetComponent<enemy_movement>().speed = 0f;
                    FindObjectOfType<player_movement>().GetComponent<player_movement>().speed = 0f;
                    FindObjectOfType<score_script>().GetComponent<score_script>().stop_working = true;
                    FindObjectOfType<points_script>().GetComponent<points_script>().show();
                    FindObjectOfType<score_over_menu>().GetComponent<score_over_menu>().show();
                    
                    pocni_timer_za_continue = false;
                    player.GetComponent<BoxCollider>().enabled = false;
                    //money += Time.timeSinceLevelLoad;
                    one_show = true;
                   
                    arrow_position.SetActive(false);

                    provjera_novih_itema();
                    FindObjectOfType<ad_manager_script>().GetComponent<ad_manager_script>().ShowAdVideo();
                    //PlayerPrefs.SetFloat("HighScore", 22);
//                    Debug.Log(PlayerPrefs.GetFloat("HighScore", 0) < (Time.timeSinceLevelLoad - FindObjectOfType<score_script>().GetComponent<score_script>().score_mem));

                    if (PlayerPrefs.GetFloat("HighScore", 0) < (Time.timeSinceLevelLoad - FindObjectOfType<score_script>().GetComponent<score_script>().score_mem))
                    {
                        
                        PlayerPrefs.SetFloat("HighScore", Time.timeSinceLevelLoad - FindObjectOfType<score_script>().GetComponent<score_script>().score_mem);
                        New_highscore.SetActive(true);

                    }
                    FindObjectOfType<highscore_over_menu>().GetComponent<highscore_over_menu>().show();
                    audioSource.Pause();


                }
            }
        }
        //Camera.main.GetComponent<Camera>().backgroundColor = new Color(228f, 234f, 241f, 0f);

    }


    public void Continue_game()
    {
        FindObjectOfType<ad_manager_script>().GetComponent<ad_manager_script>().ShowAdRewardVideo();
        FindObjectOfType<player_movement>().GetComponent<player_movement>().besmrtan_active();
        FindObjectOfType<game_parent_moving>().GetComponent<game_parent_moving>().speed = 10f;
        FindObjectOfType<spawn_enemy>().GetComponent<spawn_enemy>().spawn_enemys = true;
        FindObjectOfType<enemy_movement>().GetComponent<enemy_movement>().speed = 10f;
        FindObjectOfType<player_movement>().GetComponent<player_movement>().speed = 10f;
        FindObjectOfType<score_script>().GetComponent<score_script>().stop_working = false;
        FindObjectOfType<score_script>().GetComponent<score_script>().kraj_razlika_vremena();
        continue_button.SetActive(false);
        player.GetComponent<BoxCollider>().enabled = false;
        besmrtan = true;
        one_show = false;
        pocni_timer_za_continue = false;
        player_movement_button.SetActive(true);
        oduzimanje_vremena = true;

        mute_speaker_on_off = PlayerPrefs.GetInt("mute_volume", 0);
        if (mute_speaker_on_off == 1)
        {
            mute_speaker = false;
        }
        else
        {
            mute_speaker = true;
        }

        if (mute_speaker == false)
        {
            audioSource.Play();
        }
    }

    private void Update()
    {
      
        if (besmrtan == true)
        {
            timer -= 1;
            if (timer < 0)
            {
                besmrtan = false;
                player.GetComponent<BoxCollider>().enabled = true;
                FindObjectOfType<player_movement>().GetComponent<player_movement>().ne_besmrtan();
            }

        }
        if (pocni_timer_za_continue == true)
        {
            continue_timer -= 1;
            if (continue_timer < 0)
            {
                GameOver();
                one_show = false;
                continue_taken = true;
                

            }

        }
    }

    public void show_up_arrow_position()
    {
        if (besmrtan == true)
        {
            arrow_position.transform.rotation = Quaternion.Euler(0, 0, 90f);
            arrow_position.SetActive(true);
            arrow_position.transform.localPosition = new Vector3(-5,8,-72);
            arrow_position.transform.localScale = new Vector3(scaler_arrow_position, scaler_arrow_position, arrow_position.transform.localScale.y);
        }

    }

    public void show_down_arrow_position()
    {
        if (besmrtan == true)
        {
            arrow_position.transform.rotation = Quaternion.Euler(0, 0, -90f);
            arrow_position.SetActive(true);
            arrow_position.transform.localPosition = new Vector3(-5, 1, -72);
            arrow_position.transform.localScale = new Vector3(scaler_arrow_position, scaler_arrow_position, arrow_position.transform.localScale.y);
        }

    }

    public void hide_arrow_position()
    {
        if (besmrtan == true)
        {
            arrow_position.SetActive(false);
           
        }

    }


    public void provjera_novih_itema()
      
    {
        min_money = PlayerPrefs.GetFloat("Min_Money", 0);
        if (min_money == 0)
        {
            min_money = 10;

        }


        exclamation_mark.SetActive(false);
        if (min_money < money)
        {

                vidio = false;
                min_money = min_money * 2;
                PlayerPrefs.SetFloat("Min_Money", min_money);
                exclamation_mark.SetActive(true);
           

        }
    }

    public void Mute_spekar()
    {
       if (mute_speaker_on_off == 1)
        {
            PlayerPrefs.SetInt("mute_volume", 0);
            mute_speaker_on_off = 0;
            mute_speaker = true;
            audioSource.Pause();
            FindObjectOfType<mute_script>().GetComponent<mute_script>().change_sprite();
        }
        else
        {
            mute_speaker = false;
            PlayerPrefs.SetInt("mute_volume", 1);
            mute_speaker_on_off = 1;
            audioSource.Play();
            FindObjectOfType<mute_script>().GetComponent<mute_script>().change_sprite();
        }

    }

}

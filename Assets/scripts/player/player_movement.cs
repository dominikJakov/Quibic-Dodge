using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {

    public int dir = 1;
    public float speed = 10f;
    public GameObject player_sprite;
    private int color_numb = 1;
    private int trails_numb = 1;

    public bool besmrtan = false;

    // Materials
    public Material mat_orange;
    public Material mat_red;
    public Material mat_blue;
    public Material mat_green;
    public Material mat_black;
    public Material mat_pink;
    public Material mat_purple;
    public Material mat_tirkiz;
    public Material mat_white;
    public Material mat_yellow;

    // Materials
    public GameObject trail_1;
    public GameObject trail_2;
    public GameObject trail_3;
    public GameObject trail_4;
    public GameObject trail_5;

    AudioSource audioSource;
    public AudioClip move;



    private void Start()
    {
        trails_numb = PlayerPrefs.GetInt("trails", 0);
        color_numb = PlayerPrefs.GetInt("Color", 0);
        audioSource = GetComponent<AudioSource>();
        if (color_numb == 0)
        {
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 0f, 0f);
            //       GetComponent<TrailRenderer>().material = mat_red;
            trail_1.GetComponent<TrailRenderer>().material = mat_red;
            trail_2.GetComponent<TrailRenderer>().material = mat_red;
            trail_3.GetComponent<TrailRenderer>().material = mat_red;
            trail_4.GetComponent<TrailRenderer>().material = mat_red;
            trail_5.GetComponent<TrailRenderer>().material = mat_red;
        
        }
        if (color_numb == 1)
        {
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 0f);
            trail_1.GetComponent<TrailRenderer>().material = mat_yellow;
            trail_2.GetComponent<TrailRenderer>().material = mat_yellow;
            trail_3.GetComponent<TrailRenderer>().material = mat_yellow;
            trail_4.GetComponent<TrailRenderer>().material = mat_yellow;
            trail_5.GetComponent<TrailRenderer>().material = mat_yellow;
        }
        if (color_numb == 2)
        {
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 255f / 255f);
            trail_1.GetComponent<TrailRenderer>().material = mat_blue;
            trail_2.GetComponent<TrailRenderer>().material = mat_blue;
            trail_3.GetComponent<TrailRenderer>().material = mat_blue;
            trail_4.GetComponent<TrailRenderer>().material = mat_blue;
            trail_5.GetComponent<TrailRenderer>().material = mat_blue;
        }
        if (color_numb == 3)
        {
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(0f, 255f / 255f, 0f);
         
            trail_1.GetComponent<TrailRenderer>().material = mat_green;
            trail_2.GetComponent<TrailRenderer>().material = mat_green;
            trail_3.GetComponent<TrailRenderer>().material = mat_green;
            trail_4.GetComponent<TrailRenderer>().material = mat_green;
            trail_5.GetComponent<TrailRenderer>().material = mat_green;
        }
        if (color_numb == 4)
        {
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f);
      
            trail_1.GetComponent<TrailRenderer>().material = mat_black;
            trail_2.GetComponent<TrailRenderer>().material = mat_black;
            trail_3.GetComponent<TrailRenderer>().material = mat_black;
            trail_4.GetComponent<TrailRenderer>().material = mat_black;
            trail_5.GetComponent<TrailRenderer>().material = mat_black;
        }
        if (color_numb == 5)
        {
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f);
      
            trail_1.GetComponent<TrailRenderer>().material = mat_white;
            trail_2.GetComponent<TrailRenderer>().material = mat_white;
            trail_3.GetComponent<TrailRenderer>().material = mat_white;
            trail_4.GetComponent<TrailRenderer>().material = mat_white;
            trail_5.GetComponent<TrailRenderer>().material = mat_white;
        }
        if (color_numb == 6)
        {
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 0f, 255f / 255f);
    
            trail_1.GetComponent<TrailRenderer>().material = mat_pink;
            trail_2.GetComponent<TrailRenderer>().material = mat_pink;
            trail_3.GetComponent<TrailRenderer>().material = mat_pink;
            trail_4.GetComponent<TrailRenderer>().material = mat_pink;
            trail_5.GetComponent<TrailRenderer>().material = mat_pink;
        }
        if (color_numb == 7)
        {
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(0f, 255f / 255f, 255f / 255f);
            
            trail_1.GetComponent<TrailRenderer>().material = mat_tirkiz;
            trail_2.GetComponent<TrailRenderer>().material = mat_tirkiz;
            trail_3.GetComponent<TrailRenderer>().material = mat_tirkiz;
            trail_4.GetComponent<TrailRenderer>().material = mat_tirkiz;
            trail_5.GetComponent<TrailRenderer>().material = mat_tirkiz;
        }
        if (color_numb == 8)
        {
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(160f / 255f, 0f, 255f / 255f);
        
            trail_1.GetComponent<TrailRenderer>().material = mat_purple;
            trail_2.GetComponent<TrailRenderer>().material = mat_purple;
            trail_3.GetComponent<TrailRenderer>().material = mat_purple;
            trail_4.GetComponent<TrailRenderer>().material = mat_purple;
            trail_5.GetComponent<TrailRenderer>().material = mat_purple;
        }
        if (color_numb == 9)
        {
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 134f / 255f, 0f);
 
            trail_1.GetComponent<TrailRenderer>().material = mat_orange;
            trail_2.GetComponent<TrailRenderer>().material = mat_orange;
            trail_3.GetComponent<TrailRenderer>().material = mat_orange;
            trail_4.GetComponent<TrailRenderer>().material = mat_orange;
            trail_5.GetComponent<TrailRenderer>().material = mat_orange;
        }
  

        if (trails_numb == 1)
        {
            trail_1.GetComponent<TrailRenderer>().emitting = true;
            trail_2.GetComponent<TrailRenderer>().emitting = false;
            trail_3.GetComponent<TrailRenderer>().emitting = false;
            trail_4.GetComponent<TrailRenderer>().emitting = false;
            trail_5.GetComponent<TrailRenderer>().emitting = false;
        }

        if (trails_numb == 2)
        {
            trail_1.GetComponent<TrailRenderer>().emitting = false;
            trail_2.GetComponent<TrailRenderer>().emitting = true;
            trail_3.GetComponent<TrailRenderer>().emitting = false;
            trail_4.GetComponent<TrailRenderer>().emitting = false;
            trail_5.GetComponent<TrailRenderer>().emitting = false;
        }

        if (trails_numb == 3)
        {
            trail_1.GetComponent<TrailRenderer>().emitting = false;
            trail_2.GetComponent<TrailRenderer>().emitting = false;
            trail_3.GetComponent<TrailRenderer>().emitting = true;
            trail_4.GetComponent<TrailRenderer>().emitting = false;
            trail_5.GetComponent<TrailRenderer>().emitting = false;
        }

        if (trails_numb == 4)
        {
            trail_1.GetComponent<TrailRenderer>().emitting = false;
            trail_2.GetComponent<TrailRenderer>().emitting = false;
            trail_3.GetComponent<TrailRenderer>().emitting = false;
            trail_4.GetComponent<TrailRenderer>().emitting = true;
            trail_5.GetComponent<TrailRenderer>().emitting = false;
        }

        if (trails_numb == 5)
        {
            trail_1.GetComponent<TrailRenderer>().emitting = false;
            trail_2.GetComponent<TrailRenderer>().emitting = false;
            trail_3.GetComponent<TrailRenderer>().emitting = false;
            trail_4.GetComponent<TrailRenderer>().emitting = false;
            trail_5.GetComponent<TrailRenderer>().emitting = true;
        }

        Color dmp = player_sprite.GetComponent<SpriteRenderer>().color;
        dmp.a = 1f;
        player_sprite.GetComponent<SpriteRenderer>().color = dmp;

        Color red_trans = mat_red.color;
        red_trans.a = 1f;
        mat_red.color = red_trans;

        Color orange_trans = mat_orange.color;
        orange_trans.a = 1f;
        mat_orange.color = orange_trans;

        Color blue_trans = mat_blue.color;
        blue_trans.a = 1f;
        mat_blue.color = blue_trans;

        Color green_trans = mat_green.color;
        green_trans.a = 1f;
        mat_green.color = green_trans;

        Color black_trans = mat_black.color;
        black_trans.a = 1f;
        mat_black.color = black_trans;

        Color pink_trans = mat_pink.color;
        pink_trans.a = 1f;
        mat_pink.color = pink_trans;

        Color purple_trans = mat_purple.color;
        purple_trans.a = 1f;
        mat_purple.color = purple_trans;

        Color tirkiz_trans = mat_tirkiz.color;
        tirkiz_trans.a = 1f;
        mat_tirkiz.color = tirkiz_trans;

        Color white_trans = mat_white.color;
        white_trans.a = 1f;
        mat_white.color = white_trans;

        Color yellow_trans = mat_yellow.color;
        yellow_trans.a = 1f;
        mat_yellow.color = yellow_trans;

    }

    private void Update()
    {
        transform.Translate(0f, speed * dir * Time.deltaTime, 0f);
        
        if (transform.position.y > 8.10f)
        {
            FindObjectOfType<GameManager>().GameOver();
            FindObjectOfType<GameManager>().show_up_arrow_position();
            FindObjectOfType<GameManager>().GetComponent<GameManager>().scaler_arrow_position = (transform.position.y / 8.10f) ;
        }


        if (transform.position.y < -3f)
        {
            FindObjectOfType<GameManager>().GameOver();
            FindObjectOfType<GameManager>().show_down_arrow_position();
            FindObjectOfType<GameManager>().GetComponent<GameManager>().scaler_arrow_position = Mathf.Abs(((transform.position.y + -5.10f)/ 8.10f));
        }

        if (transform.position.y > -3f && transform.position.y < 8.10f)
        {
            
            FindObjectOfType<GameManager>().hide_arrow_position();
        }

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "enemy")
        {
            FindObjectOfType<GameManager>().GameOver();
            if (PlayerPrefs.GetInt("mute_volume", 0) == 1)
            {
                audioSource.PlayOneShot(move, 1f);
            }
        }
    }

    public void change_dir()
    {
        
        dir *= -1;
        FindObjectOfType<sprite_folow>().GetComponent<sprite_folow>().change_player_in_game_sprite();
        //speed *= -1;

    }


    public void besmrtan_active()
    {
        Color tmp = player_sprite.GetComponent<SpriteRenderer>().color;
        tmp.a = 0.5f;
        player_sprite.GetComponent<SpriteRenderer>().color = tmp;

        Color red_trans = mat_red.color;
        red_trans.a = 0.5f;
        mat_red.color = red_trans;

        Color orange_trans = mat_orange.color;
        orange_trans.a = 0.5f;
        mat_orange.color = orange_trans;

        Color blue_trans = mat_blue.color;
        blue_trans.a = 0.5f;
        mat_blue.color = blue_trans;
                                                                                                                                                                                                      
        Color green_trans = mat_green.color;
        green_trans.a = 0.5f;
        mat_green.color = green_trans;

        Color black_trans = mat_black.color;
         black_trans.a = 0.5f;
        mat_black.color = black_trans;

        Color pink_trans = mat_pink.color;
        pink_trans.a = 0.5f;
        mat_pink.color = pink_trans;

        Color purple_trans = mat_purple.color;
        purple_trans.a = 0.5f;
        mat_purple.color = purple_trans;

        Color tirkiz_trans = mat_tirkiz.color;
        tirkiz_trans.a = 0.5f;
        mat_tirkiz.color = tirkiz_trans;

        Color white_trans = mat_white.color;
        white_trans.a = 0.5f;
        mat_white.color = white_trans;

        Color yellow_trans = mat_yellow.color;
        yellow_trans.a = 0.5f;
        mat_yellow.color = yellow_trans;




    }

    public void ne_besmrtan()
    {
        Color dmp = player_sprite.GetComponent<SpriteRenderer>().color;
        dmp.a = 1f;
        player_sprite.GetComponent<SpriteRenderer>().color = dmp;

        Color red_trans = mat_red.color;
        red_trans.a = 1f;
        mat_red.color = red_trans;

        Color orange_trans = mat_orange.color;
        orange_trans.a = 1f;
        mat_orange.color = orange_trans;

        Color blue_trans = mat_blue.color;
        blue_trans.a = 1f;
        mat_blue.color = blue_trans;

        Color green_trans = mat_green.color;
        green_trans.a = 1f;
        mat_green.color = green_trans;

        Color black_trans = mat_black.color;
        black_trans.a = 1f;
        mat_black.color = black_trans;

        Color pink_trans = mat_pink.color;
        pink_trans.a = 1f;
        mat_pink.color = pink_trans;

        Color purple_trans = mat_purple.color;
        purple_trans.a = 1f;
        mat_purple.color = purple_trans;

        Color tirkiz_trans = mat_tirkiz.color;
        tirkiz_trans.a = 1f;
        mat_tirkiz.color = tirkiz_trans;

        Color white_trans = mat_white.color;
        white_trans.a = 1f;
        mat_white.color = white_trans;

        Color yellow_trans = mat_yellow.color;
        yellow_trans.a = 1f;
        mat_yellow.color = yellow_trans;
    }

}

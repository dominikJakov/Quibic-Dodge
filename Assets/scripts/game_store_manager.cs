using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;





public class game_store_manager : MonoBehaviour {

    public float money; 

    public GameObject player;
    public GameObject player_sprite;

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


    // buttons
    public Button button_orange;
    public Button button_red;
    public Button button_blue;
    public Button button_green;
    public Button button_black;
    public Button button_pink;
    public Button button_purple;
    public Button button_tirkiz;
    public Button button_white;
    public Button button_yellow;

    private float fade = 0.4f;

    // color money
    public float orange_money = 0f;
    public float red_money = 10f;
    public float blue_money = 20f;
    public float green_money = 40f;
    public float pink_money = 80f;
    public float black_money = 120f;
    public float purple_money = 240f;
    public float tirkiz_money = 480f;
    public float white_money = 960f;
    public float yellow_money = 1920f;

    // trail money
    public float trail_1_money = 0f;
    public float trail_2_money = 50f;
    public float trail_3_money = 100f;
    public float trail_4_money = 200f;
    public float trail_5_money = 400f;


    // trails
    public GameObject trail_1;
    public GameObject trail_2;
    public GameObject trail_3;
    public GameObject trail_4;
    public GameObject trail_5;

    // trails image
    public GameObject trail_1_img;
    public GameObject trail_2_img;
    public GameObject trail_3_img;
    public GameObject trail_4_img;
    public GameObject trail_5_img;

    private void Start()
    {
        restart_points();
    }


    public void restart_points()
    {

        money = PlayerPrefs.GetFloat("Money", 0);
      
    

        if (money < red_money)
        {
            button_red.GetComponent<Image>().color = new Color(0f, 0f, 0f, fade);
        }
    


        ////////////////////////////////////////////////////////////////////////////////////////
        if (money < yellow_money)
        {
           
            button_yellow.GetComponent<Image>().color = new Color(0f, 0f, 0f, fade);
        }

        ////////////////////////////////////////////////////////////////////////////////////////
        if (money < blue_money)
        {
            button_blue.GetComponent<Image>().color = new Color(0f, 0f, 0f, fade);
        }


        ////////////////////////////////////////////////////////////////////////////////////////
        if (money < green_money)
        {
            button_green.GetComponent<Image>().color = new Color(0f, 0f, 0f, fade);
        }

        ////////////////////////////////////////////////////////////////////////////////////////
        if (money < black_money)
        {
            button_black.GetComponent<Image>().color = new Color(0f, 0f, 0f, fade);
        }


        ////////////////////////////////////////////////////////////////////////////////////////
        if (money < white_money)
        {
            button_white.GetComponent<Image>().color = new Color(0f, 0f, 0f, fade);
        }


        ////////////////////////////////////////////////////////////////////////////////////////
        if (money < pink_money)
        {
            button_pink.GetComponent<Image>().color = new Color(0f, 0f, 0f, fade);
        }
   

        ////////////////////////////////////////////////////////////////////////////////////////
        if (money < tirkiz_money)
        {
            button_tirkiz.GetComponent<Image>().color = new Color(0f, 0f, 0f, fade);
        }


        ////////////////////////////////////////////////////////////////////////////////////////
        if (money < purple_money)
        {
            button_purple.GetComponent<Image>().color = new Color(0f, 0f, 0f, fade);
        }



        ////////////////////////////////////////////////////////////////////////////////////////
        if (money < trail_1_money)
        {
            trail_1_img.GetComponent<Image>().color = new Color(0f, 0f, 0f, fade);
        }


        ////////////////////////////////////////////////////////////////////////////////////////
        if (money < trail_2_money)
        {
            trail_2_img.GetComponent<Image>().color = new Color(0f, 0f, 0f, fade);
        }


        ////////////////////////////////////////////////////////////////////////////////////////
        if (money < trail_3_money)
        {
            trail_3_img.GetComponent<Image>().color = new Color(0f, 0f, 0f, fade);
        }


        ////////////////////////////////////////////////////////////////////////////////////////
        if (money < trail_4_money)
        {
            trail_4_img.GetComponent<Image>().color = new Color(0f, 0f, 0f, fade);
        }


        ////////////////////////////////////////////////////////////////////////////////////////
        if (money < trail_5_money)
        {
            trail_5_img.GetComponent<Image>().color = new Color(0f, 0f, 0f, fade);
        }


    }




    // Use this for initialization
    public void red_color () {
        if (money >= red_money)
        {
            trail_1.GetComponent<TrailRenderer>().material = mat_red;
            trail_2.GetComponent<TrailRenderer>().material = mat_red;
            trail_3.GetComponent<TrailRenderer>().material = mat_red;
            trail_4.GetComponent<TrailRenderer>().material = mat_red;
            trail_5.GetComponent<TrailRenderer>().material = mat_red;
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 0f, 0f);
            PlayerPrefs.SetInt("Color", 0);
    
        }
 
    }

    public void yellow_color()
    {
        if (money >= yellow_money)
        {
            trail_1.GetComponent<TrailRenderer>().material = mat_yellow;
            trail_2.GetComponent<TrailRenderer>().material = mat_yellow;
            trail_3.GetComponent<TrailRenderer>().material = mat_yellow;
            trail_4.GetComponent<TrailRenderer>().material = mat_yellow;
            trail_5.GetComponent<TrailRenderer>().material = mat_yellow;
     
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 0f);
            PlayerPrefs.SetInt("Color", 1);
            
        }
    }

    public void blue_color()
    {
        if (money >= blue_money)
        {
            trail_1.GetComponent<TrailRenderer>().material = mat_blue;
            trail_2.GetComponent<TrailRenderer>().material = mat_blue;
            trail_3.GetComponent<TrailRenderer>().material = mat_blue;
            trail_4.GetComponent<TrailRenderer>().material = mat_blue;
            trail_5.GetComponent<TrailRenderer>().material = mat_blue;
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 255f / 255f);
            PlayerPrefs.SetInt("Color", 2);
            
        }
    }

    public void green_color()
    {
        if (money >= green_money)
        {
            trail_1.GetComponent<TrailRenderer>().material = mat_green;
            trail_2.GetComponent<TrailRenderer>().material = mat_green;
            trail_3.GetComponent<TrailRenderer>().material = mat_green;
            trail_4.GetComponent<TrailRenderer>().material = mat_green;
            trail_5.GetComponent<TrailRenderer>().material = mat_green;
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(0f, 255f / 255f, 0f);
            PlayerPrefs.SetInt("Color", 3);
           
        }
    }

    public void black_color()
    {
        if (money >= black_money)
        {
            trail_1.GetComponent<TrailRenderer>().material = mat_black;
            trail_2.GetComponent<TrailRenderer>().material = mat_black;
            trail_3.GetComponent<TrailRenderer>().material = mat_black;
            trail_4.GetComponent<TrailRenderer>().material = mat_black;
            trail_5.GetComponent<TrailRenderer>().material = mat_black;
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f);
            PlayerPrefs.SetInt("Color", 4);
          
        }
    }

    public void white_color()
    {
        if (money >= white_money)
        {
            trail_1.GetComponent<TrailRenderer>().material = mat_white;
            trail_2.GetComponent<TrailRenderer>().material = mat_white;
            trail_3.GetComponent<TrailRenderer>().material = mat_white;
            trail_4.GetComponent<TrailRenderer>().material = mat_white;
            trail_5.GetComponent<TrailRenderer>().material = mat_white;
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f);
            PlayerPrefs.SetInt("Color", 5);
            
        }
    }

    public void pink_color()
    {
        if (money >= pink_money)
        {
            trail_1.GetComponent<TrailRenderer>().material = mat_pink;
            trail_2.GetComponent<TrailRenderer>().material = mat_pink;
            trail_3.GetComponent<TrailRenderer>().material = mat_pink;
            trail_4.GetComponent<TrailRenderer>().material = mat_pink;
            trail_5.GetComponent<TrailRenderer>().material = mat_pink;
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 0f, 255f / 255f);
            PlayerPrefs.SetInt("Color", 6);
            
        }
    }

    public void tirkiz_color()
    {
        if (money >= tirkiz_money)
        {
            trail_1.GetComponent<TrailRenderer>().material = mat_tirkiz;
            trail_2.GetComponent<TrailRenderer>().material = mat_tirkiz;
            trail_3.GetComponent<TrailRenderer>().material = mat_tirkiz;
            trail_4.GetComponent<TrailRenderer>().material = mat_tirkiz;
            trail_5.GetComponent<TrailRenderer>().material = mat_tirkiz;
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(0f, 255f / 255f, 255f / 255f);
            PlayerPrefs.SetInt("Color", 7);
            
        }
    }

    public void purple_color()
    {
        if (money >= purple_money)
        {
            trail_1.GetComponent<TrailRenderer>().material = mat_purple;
            trail_2.GetComponent<TrailRenderer>().material = mat_purple;
            trail_3.GetComponent<TrailRenderer>().material = mat_purple;
            trail_4.GetComponent<TrailRenderer>().material = mat_purple;
            trail_5.GetComponent<TrailRenderer>().material = mat_purple;
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(190f / 255f, 0f, 255f / 255f);
            PlayerPrefs.SetInt("Color", 8);
           
        }
    }

    public void orange_color()
    {
        if (money >= orange_money)
        {
            trail_1.GetComponent<TrailRenderer>().material = mat_orange;
            trail_2.GetComponent<TrailRenderer>().material = mat_orange;
            trail_3.GetComponent<TrailRenderer>().material = mat_orange;
            trail_4.GetComponent<TrailRenderer>().material = mat_orange;
            trail_5.GetComponent<TrailRenderer>().material = mat_orange;
            player_sprite.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 134f / 255f, 0f / 255f);
            PlayerPrefs.SetInt("Color", 9);
           
        }
    }

    public void trail_1_activate()
    {
        if (money >= trail_1_money)
        {
            PlayerPrefs.SetInt("trails", 1);
            trail_1.GetComponent<TrailRenderer>().emitting = true;
            trail_2.GetComponent<TrailRenderer>().emitting = false;
            trail_3.GetComponent<TrailRenderer>().emitting = false;
            trail_4.GetComponent<TrailRenderer>().emitting = false;
            trail_5.GetComponent<TrailRenderer>().emitting = false;
        }
    }

    public void trail_2_activate()
    {
        if (money >= trail_2_money)
        {
            PlayerPrefs.SetInt("trails", 2);
            trail_1.GetComponent<TrailRenderer>().emitting = false;
            trail_2.GetComponent<TrailRenderer>().emitting = true;
            trail_3.GetComponent<TrailRenderer>().emitting = false;
            trail_4.GetComponent<TrailRenderer>().emitting = false;
            trail_5.GetComponent<TrailRenderer>().emitting = false;
        }
    }

    public void trail_3_activate()
    {
        if (money >= trail_3_money)
        {
            PlayerPrefs.SetInt("trails", 3);
            trail_1.GetComponent<TrailRenderer>().emitting = false;
            trail_2.GetComponent<TrailRenderer>().emitting = false;
            trail_3.GetComponent<TrailRenderer>().emitting = true;
            trail_4.GetComponent<TrailRenderer>().emitting = false;
            trail_5.GetComponent<TrailRenderer>().emitting = false;
        }
    }

    public void trail_4_activate()
    {
        if (money >= trail_4_money)
        {
            PlayerPrefs.SetInt("trails", 4);
            trail_1.GetComponent<TrailRenderer>().emitting = false;
            trail_2.GetComponent<TrailRenderer>().emitting = false;
            trail_3.GetComponent<TrailRenderer>().emitting = false;
            trail_4.GetComponent<TrailRenderer>().emitting = true;
            trail_5.GetComponent<TrailRenderer>().emitting = false;
        }
    }

    public void trail_5_activate()
    {
        
        if (money >= trail_5_money)
        {
            
            PlayerPrefs.SetInt("trails", 5);
            trail_1.GetComponent<TrailRenderer>().emitting = false;
            trail_2.GetComponent<TrailRenderer>().emitting = false;
            trail_3.GetComponent<TrailRenderer>().emitting = false;
            trail_4.GetComponent<TrailRenderer>().emitting = false;
            trail_5.GetComponent<TrailRenderer>().emitting = true;
        }
    }


    public void Back_button()
    {
        SceneManager.LoadScene("Main Menu");
    }




}

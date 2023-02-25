using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite_folow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void change_player_sprite () {


        if (FindObjectOfType<store_player>().GetComponent<store_player>().dir == -1)
        {

            transform.rotation = Quaternion.Euler(0, 0, -89.73601f);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, -0.265f);

        }

    }

    public void change_player_in_game_sprite()
    {

        //transform.position =  FindObjectOfType<player_movement>().transform.position ;
        if (FindObjectOfType<player_movement>().GetComponent<player_movement>().dir == -1)
        {
            if (FindObjectOfType<GameManager>().GetComponent<GameManager>().continue_taken == false )
            {
                transform.rotation = Quaternion.Euler(0, 0, -95.802f);  //-97.687f //  -93.661f
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, -89.94701f);
            }
        }
        else
        {
            if (FindObjectOfType<GameManager>().GetComponent<GameManager>().continue_taken == false)
            {
                transform.rotation = Quaternion.Euler(0, 0, 6.396f);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, -0.407f);
            }


        }

    }
}

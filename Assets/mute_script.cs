using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mute_script : MonoBehaviour {


    public Button currentButton;
    public Sprite muteSprite;
    public Sprite unmuteSprite;
    Image myImageComponent;

    private void Start()
    {
        myImageComponent = GetComponent<Image>();

       currentButton.interactable = true;
        if (PlayerPrefs.GetInt("mute_volume", 0) == 0)
        {
            myImageComponent.sprite = muteSprite;
        }
        else
        {
            myImageComponent.sprite = unmuteSprite;
        }       
    }

    public void change_sprite()
    {
        if (PlayerPrefs.GetInt("mute_volume", 0) == 0)
        {
            myImageComponent.sprite = muteSprite;
        }
        else
        {
            myImageComponent.sprite = unmuteSprite;
        }


    }
}

	



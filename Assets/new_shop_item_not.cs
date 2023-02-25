using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class new_shop_item_not : MonoBehaviour {

    private bool vidio = true;
    private float money = 0f;
    private float min_money = 10f;
    public Image image;

    // Use this for initialization
    public void provjera_novih_itema () {
        money = PlayerPrefs.GetFloat("Money", 0);

            if (min_money < money)
            {
                vidio = false;
            min_money *= 2f;

        }
    }
	
}

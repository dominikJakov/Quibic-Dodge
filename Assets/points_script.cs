using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class points_script : MonoBehaviour {

    public Text points_text;

    void Start()
    {
        points_text.text = PlayerPrefs.GetFloat("Money", 0).ToString("0");
    }


    // Update is called once per frame
    public void show() {
        points_text.text = PlayerPrefs.GetFloat("Money", 0).ToString("0");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class highscore_over_menu : MonoBehaviour {

    public Text scoretext;


    // Use this for initialization


    void Start()
    {


        scoretext.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");

    }

    public void show()
    {


        scoretext.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");

    }
}

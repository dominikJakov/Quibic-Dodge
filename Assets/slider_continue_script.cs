using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider_continue_script : MonoBehaviour {

    public Slider mainSlider;
    public bool pokrenuti = false;
    public float speed = 0.001f;


    void Update()
    {
        if (pokrenuti == true)
        {

            mainSlider.value += speed * Time.deltaTime;

        }

    }
}

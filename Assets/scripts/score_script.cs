using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score_script : MonoBehaviour {

    private float red;
    private float green;
    private float blue;
    public bool stop_working = false;
    public Text scoretext;
    public float score_mem = 0f;
    public float score_relativ_mem = 0f;



    public void razlika_vremena()
    {

        score_relativ_mem = Time.timeSinceLevelLoad;
    }

    public void kraj_razlika_vremena()
    {

        score_mem = Time.timeSinceLevelLoad - score_relativ_mem;
    }


    // Update is called once per frame
    void Update () {
        if (stop_working == false)
        {
            scoretext.text = (Time.timeSinceLevelLoad - score_mem).ToString("0");
            red = FindObjectOfType<camera_chage_color>().GetComponent<camera_chage_color>().r - 30f;
            green = FindObjectOfType<camera_chage_color>().GetComponent<camera_chage_color>().g - 30f;
            blue = FindObjectOfType<camera_chage_color>().GetComponent<camera_chage_color>().b - 30f;
            scoretext.color = new Color(red / 255f, green / 255f, blue / 255f, 70f / 255f);
        }
    }
}

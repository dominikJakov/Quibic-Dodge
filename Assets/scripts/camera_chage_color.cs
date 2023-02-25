using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_chage_color : MonoBehaviour {

    public int r = 135;
    public int b = 255;
    public int g = 255;

    private int min = 175;
    private int max = 255;


    public Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
    }

    void Update()
    {

    


        //  cam.backgroundColor = Color.Lerp(color1, color2, 1f);
        if (r == min)
        {
            if (g != max)
            {
                g += 1;
            }
            else
            {
                if (b > min)
                {
                    b -= 1;
                }
            }

        }
        if (g == min)
        {
            if (b != max)
            {
                b += 1;
            }
            else
            {
                if (r > min)
                {
                    r -= 1;
                }
            }
        }

        if (b == min)
        {
            if (r != max)
            {
                r += 1;
            }
            else
            {
                if (g > min)
                {
                    g -= 1;
                }
            }       
        }
        cam.backgroundColor = new Color(r / 255f, b / 255f, g / 255f);
    }
}


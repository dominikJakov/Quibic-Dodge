using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_over_menu : MonoBehaviour {

    public Text scoretext;
   

    // Use this for initialization
    public void show () {
 
            scoretext.text = (Time.timeSinceLevelLoad - FindObjectOfType<score_script>().GetComponent<score_script>().score_mem).ToString("0");


    }
	
	
}

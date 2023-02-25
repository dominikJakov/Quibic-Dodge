using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_parent_moving : MonoBehaviour {

    public float speed = 10f;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed * Time.deltaTime,0f,0f);
	}
}

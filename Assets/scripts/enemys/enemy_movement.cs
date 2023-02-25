using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour {

    public float postion_x = 10f;
    public float speed = 10f;
    private float start_position;
    

	// Use this for initialization
	void Start () {
        start_position = transform.position.x;
        //transform.localPosition = new Vector3(10f, Random.Range(6.5f, -2f),0f);
    }
	
	// Update is called once per frame
	void Update () {
   
        postion_x += 5f * Time.deltaTime;
        transform.Translate(-speed * Time.deltaTime,0f,0f);
        if (transform.localPosition.x < start_position - 20f)
        {

            Destroy(gameObject);
        }

       
    }
}

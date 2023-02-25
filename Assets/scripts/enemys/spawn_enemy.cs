using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_enemy : MonoBehaviour {

    public GameObject enemy;
    public int brojanje = 0;
    public bool spawn_enemys = true;


    private void Start()
    {
        Instantiate(enemy, new Vector3(transform.position.x, 10, 0f), Quaternion.identity);
    }

    void Update () {
        if (spawn_enemys == true)
        {
            brojanje += 1;
            if (brojanje % 60 == 0)
            {
                Instantiate(enemy, new Vector3(transform.position.x, Random.Range(6.5f, -2f), -0.1f), Quaternion.identity);

            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{


    [SerializeField] GameObject cubePrefab;

    [SerializeField] int numberOfObjects = 100;

    [SerializeField] float radius = 20f;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//////PRESS SPACEBAR TO INTITIATE GAMEOBJECTS
        {

            for (int i = 0; i < numberOfObjects; i++)
            {
                float angle = i * Mathf.PI * 2 / numberOfObjects;
                float x = Mathf.Cos(angle) * radius;
                float z = Mathf.Sin(angle) * radius;
                Vector3 pos = transform.position + new Vector3(x, 0, z);
                float angleDegrees = -angle * Mathf.Rad2Deg;
                Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
                Instantiate(cubePrefab, pos, rot);


            }
        }
    }
}



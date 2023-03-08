using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colo : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    void Start()
    {
        ChangeColor();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) ////PRESS Q TO CHANGE COLOR OF CUBES
        {
            ChangeColor();
        }

    }
    void ChangeColor()
    {
        meshRenderer.material.color = Random.ColorHSV();
    }
}


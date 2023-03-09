using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorh : MonoBehaviour
{
    public Material BlueMaterial;
    public Material YellowMaterial;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            transform.GetComponent<Renderer>().material = BlueMaterial;
        }

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Box")
        {
            transform.GetComponent<Renderer>().material = YellowMaterial;
        }

    }
}

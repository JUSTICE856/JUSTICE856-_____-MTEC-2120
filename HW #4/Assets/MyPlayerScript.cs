using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

[RequireComponent(typeof(PlayerInput))]
public class MyPlayerScript : MonoBehaviour
{

    public delegate void OnClickEvent(GameObject g);
    public event OnClickEvent OnClick;

    public string box { get; set; }


    public MyPlayerScript(string g)
    {
        this.box = g;
    }
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit[] hits = Physics.RaycastAll(ray);
        for (int i = 0; i < hits.Length; i++)
        {
            OnClick(hits[i].collider.gameObject);
        }
    }
    public void OnClicked()
    {
        bool wasClicked = true;
        bool OnClick = true;

            if (OnClick == true)
            {
                 OnClick = (this.gameObject) ;
            }

            if (wasClicked == true)
            {
                Debug.Log("GameObject");


            }

        }
    }



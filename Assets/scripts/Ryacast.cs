using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    Animator anim;
    public GameObject Grinder;
    public GameObject Bin;
    public GameObject Plate;
    public GameObject Lighter;
    public GameObject Fire;
    private void Start()
    {
        anim = Grinder.GetComponent<Animator>();
        Fire.SetActive(false);
    }

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.name == "Grinder")
                {
                    anim = Grinder.GetComponent<Animator>();
                    anim.SetTrigger("Active");

                }
                if (hit.collider.name == "TrashCan")
                {
                    anim = Bin.GetComponent<Animator>();
                    anim.SetTrigger("Active");

                }
                if (hit.collider.name == "Plate")
                {
                    anim = Plate.GetComponent<Animator>();
                    anim.SetTrigger("Active");

                }
                if (hit.collider.name == "Lighter") 
                {
                    anim = Lighter.GetComponent<Animator>();
                    anim.SetTrigger("Opened");
                    Fire.SetActive(true); 
                }
            }

        }
    }
}



    
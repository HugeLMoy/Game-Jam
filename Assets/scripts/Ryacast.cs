using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public GameObject Box;
    public GameObject Smoke;
    public GameObject SmokeUp;
    public GameObject RadioButton1;
    public GameObject RadioButton2;
    public GameObject RadioButton3;

    private void Start()
    {
        anim = Grinder.GetComponent<Animator>();
        Fire.SetActive(false);
        Smoke.SetActive(false);
        SmokeUp.SetActive(false);
    }

    IEnumerator Timer() 
    {
        yield return new WaitForSeconds(5);
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
                if (hit.collider.name == "Box")
                {
                    anim = Box.GetComponent<Animator>();
                    anim.SetTrigger("Active");
                }
                if (hit.collider.name == "RadioButton1")
                {
                    anim = RadioButton1.GetComponent<Animator>();
                    anim.SetTrigger("Active");
                }
                if (hit.collider.name == "RadioButton2")
                {
                    anim = RadioButton2.GetComponent<Animator>();
                    anim.SetTrigger("Active");
                }
                if (hit.collider.name == "RadioButton3")
                {
                    anim = RadioButton3.GetComponent<Animator>();
                    anim.SetTrigger("Active");
                }
                if (hit.collider.name == "Lighter")
                {
                    anim = Lighter.GetComponent<Animator>();
                    anim.SetTrigger("Opened");
                    Fire.SetActive(true);
                    SmokeUp.SetActive(true);
                }
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hit.collider.name == "Lighter")
                    {
                        Smoke.SetActive(true);
                        StartCoroutine(Timer());
                        SceneManager.LoadSceneAsync(2);
                    }

            }

        }
    }
}



    
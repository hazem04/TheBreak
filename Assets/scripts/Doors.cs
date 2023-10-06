using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doors : MonoBehaviour
{
    //public Animator door;
    public GameObject openText;
    public GameObject KeyINV;
    public GameObject Key2;
    public GameObject Key3;
    public GameObject Key4;
    public GameObject wonHUD;
    public GameObject needKeys;
    
    public AudioSource doorSound;
    public AudioSource lockedSound;


    public bool inReach;
    public bool unlocked;
    public bool locked;
    public bool hasKey;





    void Start()
    {
        inReach = false;
        hasKey = false;
        unlocked = false;
        locked = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            openText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            openText.SetActive(false);
            needKeys.SetActive(false);
            

        }
    }





    void Update()
    {
        if (KeyINV.activeInHierarchy && Key2.activeInHierarchy && Key3.activeInHierarchy && Key4.activeInHierarchy)
        {
            locked = false;
            hasKey = true;
        }

        else
        {
            hasKey = false;
        }

        if (hasKey && inReach && Input.GetButtonDown("Interact"))
        {
            unlocked = true;
            DoorOpens();
        }

       

        if (locked && inReach && Input.GetButtonDown("Interact"))
        {
            lockedSound.Play();
            openText.SetActive(false);
            needKeys.SetActive(true);

        }




    }
    void DoorOpens()
    {
        if (unlocked)
        {
            openText.SetActive(false);
            Time.timeScale = 0;
            wonHUD.SetActive(true);
            
            doorSound.Play();
        }

    }

   


}
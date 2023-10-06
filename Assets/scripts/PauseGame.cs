using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseGame : MonoBehaviour
{
    public GameObject menu;
    public GameObject resume;
    public GameObject quit;
    public GameObject objective;
    public AudioSource buttonSound;
    
    public bool on;
    public bool off;





    void Start()
    {
        menu.SetActive(false);
        off = true;
        on = false;
    }




    void Update()
    {
        if (off && Input.GetButtonDown("pause"))
        {
            buttonSound.Play();
            Time.timeScale = 0;
            menu.SetActive(true);
            off = false;
            on = true;
            
            objective.SetActive(false);
            
        }

        else if (on && Input.GetButtonDown("pause"))
        {
            buttonSound.Play();
            Time.timeScale = 1;
            menu.SetActive(false);
            off = true;
            on = false;
        }

    }

    public void Resume()
    {
        buttonSound.Play();
        Time.timeScale = 1;
        menu.SetActive(false);
        off = true;
        on = false;

    }

    public void Exit()
    {
        buttonSound.Play();
        SceneManager.LoadScene("Scenes/MainMenu");
        

    }
}
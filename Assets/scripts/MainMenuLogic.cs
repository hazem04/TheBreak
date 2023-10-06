using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{
    private GameObject mainMenu;

    private GameObject loading;

    public AudioSource buttonSound;



    void Start()
    {
        Cursor.visible = true;
        Screen.lockCursor = false;
        mainMenu = GameObject.Find("MainMenuCanvas");

        loading = GameObject.Find("LoadingCanvas");

        mainMenu.GetComponent<Canvas>().enabled = true;
        loading.GetComponent<Canvas>().enabled = false;
    }

    public void StartButton()
    {
        loading.GetComponent<Canvas>().enabled = true;
        mainMenu.GetComponent<Canvas>().enabled = false;
        buttonSound.Play();
        SceneManager.LoadScene("Abandoned_Asylum/Show");
    }

   

    public void ExitGameButton()
    {
        buttonSound.Play();
        Application.Quit();
        Debug.Log("App Has Exited");
    }

    



    void Update()
    {

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ED_MenuManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame_Bttn()
    {
        SceneManager.LoadScene("Game_Scene");
    }

    public void Credits_Bttn()
    {
        SceneManager.LoadScene("Credits_Scene");
    }

    public void Exit_Bttn()
    {
        Application.Quit();
    }
}

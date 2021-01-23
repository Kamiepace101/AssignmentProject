using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenuUI : MonoBehaviour
{
public static bool GameisPaused = false;
public GameObject PasueMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused)
            {
                Resume(); 
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume ()
    {
        PasueMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }
    void Pause ()
    {
        PasueMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }
    public void LoadMenu ()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("0");
    }
    public void QuitGame ()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}

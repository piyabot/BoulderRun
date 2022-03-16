using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void exit()
    {
        Application.Quit();
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void level_select()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void retry()
    {
        { Time.timeScale = 1; }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

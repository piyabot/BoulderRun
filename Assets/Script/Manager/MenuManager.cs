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
        SceneManager.LoadScene("MainMenu");
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
    public void Lv1_1()
    {
        SceneManager.LoadScene("Lv1_1");
    }
    public void Lv1_2()
    {
        SceneManager.LoadScene("Lv1_2");
    }
    public void Lv1_3()
    {
        SceneManager.LoadScene("Lv1_3");
    }
    public void Lv1_4()
    {
        SceneManager.LoadScene("Lv1_4");
    }
    public void Lv1_5()
    {
        SceneManager.LoadScene("Lv1_5");
    }
}

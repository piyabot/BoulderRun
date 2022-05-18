using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    public int nextSceneLoad;
    public GameObject Win;

    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    void OnTriggerEnter(Collider other) //Load next level and unlock that level
    {
        if (other.tag == "Player")
        {
            Win.SetActive(true);
            { Time.timeScale = 0; }
            SceneManager.LoadScene(nextSceneLoad);

            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }
        }
    }
}

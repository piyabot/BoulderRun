using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDisplay : MonoBehaviour
{
    [SerializeField] Sprite LevelImage;
    [SerializeField] Image Level_Display;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeImage()
    {
        Level_Display.sprite = LevelImage;
    }
}

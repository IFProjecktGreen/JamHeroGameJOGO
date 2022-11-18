using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    
    private bool pause = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BotaoPause();
        }
    }

    public void BotaoPause()
    {
        if (!pause)
        {
            pause = true;
            Time.timeScale = 0f;
            canvas.enabled = true;
        }
        else
        {
            pause = false;
            Time.timeScale = 1f;
            canvas.enabled = false;
        }
    }


    public void Menu()
    {
        SceneManager.LoadScene("Menu Principal");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditos : MonoBehaviour
{
    private float contdown = 15f; 

    void Update()
    {
        contdown -= Time.deltaTime;
        if( contdown <= 0)
        {
            SceneManager.LoadScene("Menu Principal");
        }
    }
}

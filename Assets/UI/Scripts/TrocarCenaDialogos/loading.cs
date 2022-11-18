using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{
    private float contdown = 5f;
    void Update()
    {
        contdown -= Time.deltaTime;
        if(contdown <= 0)
        {
            SceneManager.LoadScene("Menu Principal");
        }
    }
}

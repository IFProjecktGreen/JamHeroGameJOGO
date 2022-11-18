using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FimHistória2 : MonoBehaviour
{
    private float contdown = 17f;
    void Update()
    {
        contdown -= Time.deltaTime;
        if(contdown <= 0)
        {
            SceneManager.LoadScene("Scene 4 - Festa-Interior");
        }
    }
}

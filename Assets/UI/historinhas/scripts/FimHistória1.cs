using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FimHistória1 : MonoBehaviour
{
    private float contdown = 34f;

    // Update is called once per frame
    void Update()
    {
        contdown -= Time.deltaTime;
        if(contdown <= 0)
        {
            SceneManager.LoadScene("Scene 1 - Casa_Moderna-Fora");
        }
    }
}

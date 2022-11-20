using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FimHistória3 : MonoBehaviour
{
    private float contdown = 36f;

    // Update is called once per frame
    void Update()
    {
        contdown -= Time.deltaTime;
        if (contdown <= 0)
        {
            SceneManager.LoadScene("Scene 6 - Chale-Fora");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Scene 6 - Chale-Fora");
        }
    }
}

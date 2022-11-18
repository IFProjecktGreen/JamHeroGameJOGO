using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cena1 : MonoBehaviour
{
    private bool proximo = false;

    private float contdown = 3f;
    private bool abrir = false;

    public Animator animator; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        proximo = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        proximo = false;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && proximo)
        {
            abrir = true;
            animator.SetBool("abrir", true);
        }

        if (abrir)
        {
            contdown -= Time.deltaTime;
            if (contdown <= 0)
            {
                SceneManager.LoadScene("Scene 2 - Casa_Moderna - Interno");
            }
        }

    }
}

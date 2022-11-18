using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transicao : MonoBehaviour
{
    private float contdown;

    public Animator animator;

    private void Start()
    {
        contdown = 2f;
    }

    void Update()
    {
        contdown -= Time.deltaTime;
        if(contdown <= 0)
        {
            animator.SetBool("Iniciar", false);
        }
        else
        {
            animator.SetBool("Iniciar", true);
        }
    }
}

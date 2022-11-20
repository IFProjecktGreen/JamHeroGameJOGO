using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class paredes : MonoBehaviour
{
    private float contdown = 3f;
    public Canvas canvas;
    private bool saiu = false;
    static public bool ativo = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canvas.enabled = true;
        ativo = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        saiu = true;
        contdown = 3f;
    }

    private void Update()
    {
        if(saiu == true)
        {
            contdown -= Time.deltaTime;
            if(contdown <= 0)
            {
                canvas.enabled = false;
                contdown = 3f;
                ativo = false;
            }
        }
    }
}

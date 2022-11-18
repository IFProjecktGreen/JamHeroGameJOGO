using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inicioRep : MonoBehaviour
{ 
    public Canvas canvas;
    public Animator animator;

    private float contdown = 4f;

    private string ContratoDemonio;
    private string cama;

    private bool ativo = false;
    private bool animacao = false;

void Update()
{
        ContratoDemonio = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("DemonioContrato")).value;
        cama = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("CamaCena6")).value;


    if (ContratoDemonio == "true" || cama == "true")
    {
        if (ativo == false)
        {
                ativaranimation();

                if (animacao)
                {
                    fim();
                }
                else
                {
                    canvas.enabled = true;
                }
        }
    }

    if(ContratoDemonio == "true")
        {
            ativo = false;
        }
}

void ativaranimation()
{
    if (Input.GetKeyDown(KeyCode.E) && animacao == false)
    {
        animacao = true;
        animator.SetBool("aparecer", true);
    }
}

void fim()
{
    contdown -= Time.deltaTime;
    if (contdown <= 0)
    {
        canvas.enabled = false;
        ativo = true;
        animacao = false;
        contdown = 4f;
        animator.SetBool("aparecer", false);

        if (ContratoDemonio == "true")
        {
            SceneManager.LoadScene("Scene 2 - Casa_Moderna - Interno rep1");
        }
    }
}
}

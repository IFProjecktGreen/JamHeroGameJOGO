using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamaTelaPreta : MonoBehaviour
{

    [SerializeField] private Canvas canvas;
    [SerializeField] private Animator animator;
    private string CamaCena6;
    private bool animacao = false;
    private float contdown = 3f;
    private bool ativo = false;
    private string DemonioContrato;

    void Update()
    {
        CamaCena6 = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("CamaCena6")).value;
        DemonioContrato = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("DemonioContrato")).value;

        if (CamaCena6 == "true" && !ativo)
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

        if( DemonioContrato == "true")
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
            animacao = false;
            ativo = true;
            contdown = 3f;
            animator.SetBool("aparecer", false);

            if(DemonioContrato == "true")
            {
                Debug.Log("oi");
            }
        }
    }
}

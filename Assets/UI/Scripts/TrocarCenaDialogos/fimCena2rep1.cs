using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fimCena2rep1 : MonoBehaviour
{
    public Canvas canvas;
    public Animator animator;

    private float contdown = 2f;

    private string Fim_Cena1;
    private string FinalFeliz;
    private string filha_urso;

    private bool ativo = false;
    private bool animacao = false;

    void Update()
    {
        Fim_Cena1 = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("fim_cena1")).value;
        FinalFeliz = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("FinalFeliz")).value;
        filha_urso = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("filha_urso")).value;

        if (Fim_Cena1 == "true" || FinalFeliz == "true" || filha_urso == "true")
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
            contdown = 2f;
            animator.SetBool("aparecer", false);
            if (Fim_Cena1 == "true")
            {
                SceneManager.LoadScene("Scene 4 - Festa-Interior SemUrso");
            }
            else if (FinalFeliz == "true")
            {
                SceneManager.LoadScene("FinalFeliz1");
            }
            else if(filha_urso == "true")
            {
                SceneManager.LoadScene("Scene 4 - Festa-Interior rep1");
            }
        }
    }
}
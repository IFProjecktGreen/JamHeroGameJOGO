using UnityEngine;
using UnityEngine.SceneManagement;

public class inicioRep : MonoBehaviour
{ 
    public Canvas canvas;
    public Animator animator;

    private float contdown = 4f;

    private string ContratoDemonio;
    private string cama;
    private string Final1;

    private bool ativo = false;
    private bool animacao = false;

void Update()
{
        ContratoDemonio = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("DemonioContrato")).value;
        cama = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("CamaCena6")).value;
        Final1 = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("Final1")).value;


        if (ContratoDemonio == "true" || cama == "true" || Final1 == "true")
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

    if(Final1 == "true")
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
    }
    else if( contdown <= 2)
        {
            if (ContratoDemonio == "true")
            {
                SceneManager.LoadScene("Scene 1 - Casa_Moderna-Fora 1");
            }
            else if (Final1 == "true")
            {
                SceneManager.LoadScene("FinalTriste1 rep2");
            }
        }
}
}

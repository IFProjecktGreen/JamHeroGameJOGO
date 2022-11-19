using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FimCena4 : MonoBehaviour
{
    public GameObject cerveja1;
    public GameObject cerveja2;
    public GameObject cervejaDerramada1;
    public GameObject cervejaDerramada2;

    private string Chefe;
    private string Fim_Cena4;
    private string FinalFeliz;
    private string repeat;

    private float contdown = 4f;
    private float contdown2 = 2.5f;

    public Animator animator;
    public Canvas canvas;

    private bool animacao = false;
    private bool ativo = false;

    SpriteRenderer sc1;
    SpriteRenderer sc2;
    SpriteRenderer scD1;
    SpriteRenderer scD2;
    public SpriteRenderer[] spriteRenderers;

    private void Start()
    {
        sc1 = cerveja1.GetComponent<SpriteRenderer>();
        sc2 = cerveja2.GetComponent<SpriteRenderer>();
        scD1 = cervejaDerramada1.GetComponent<SpriteRenderer>();
        scD2 = cervejaDerramada2.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Chefe = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("chefe")).value;
        Fim_Cena4 = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("FimCena4")).value;
        FinalFeliz = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("Final1")).value;
        repeat = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("repeat")).value;

        if (Chefe == "true" || FinalFeliz == "true" || repeat == "true")
        {
            if(ativo == false)
            {
                ativaranimation();

                if (animacao)
                {
                    fim();
                }
            }
        }

        if (Fim_Cena4 == "true")
        {
            ativo = false;
        }

        if(repeat == "true")
        {
            ativo = false;
        }

        if (contdown2 > 0 && Chefe == "true")
        {
            contdown2 -= Time.deltaTime;
            if (contdown2 <= 0)
            {
                ativarsprite();
            }
        }
    }

    void ativarsprite()
    {
        sc1.enabled = false;
        sc2.enabled = false;
        scD1.enabled = true;
        scD2.enabled = true;
        chao();
    }

    void ativaranimation()
    {
        if (Input.GetKeyDown(KeyCode.E) && animacao == false)
        {
            animacao = true;
            canvas.enabled = true;
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

        }

        else if (contdown <= 2)
        {
            if (Fim_Cena4 == "true")
            {
                SceneManager.LoadScene("Scene 3 - Estrada_Para_A_Festa_E_Estrada_Para_Casa");
            }
        }
    }

    void chao()
    {
        foreach(SpriteRenderer x in spriteRenderers)
        {
            x.enabled = true;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final1 : MonoBehaviour
{
    private string Final11;
    private float contdown = 2f;
    private bool ativar = false;

    public Animator anim;

    void Update()
    {
        Final11 = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("Final1")).value;


        if (Final11 == "true" && Input.GetKeyDown(KeyCode.E))
        {
            ativar = true;
        }

        if (ativar)
        {
            anim.SetBool("fim", true);
            contdown -= Time.deltaTime;
            if (contdown <= 0)
            {
                SceneManager.LoadScene("Menu Principal");
            }
        }
    }
}

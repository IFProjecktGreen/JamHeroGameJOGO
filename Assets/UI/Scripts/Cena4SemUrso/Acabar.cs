using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acabar : MonoBehaviour
{
    public GameObject filha;
    public BoxCollider2D janela;

    private string Chefe;
    private string Janela;

    // Update is called once per frame
    void Update()
    {
        Chefe = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("chefe")).value;
        Janela = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("janela")).value;

        if (Chefe == "true")
        {
            filha.SetActive(false);
        }

        if(Janela == "true")
        {
            janela.enabled = true;
        }
    }
}

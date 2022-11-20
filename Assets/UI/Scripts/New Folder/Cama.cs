using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cama : MonoBehaviour
{
    public string CamaCena6;
    public BoxCollider2D cama;

    private void Update()
    {
        CamaCena6 = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("CamaCena6")).value;

        if(CamaCena6 == "true")
        {
            cama.enabled = false;
        }
    }
}

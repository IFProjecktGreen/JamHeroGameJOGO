using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtVoltarConfig : MonoBehaviour
{
    public Canvas canvasconfig;
    public Canvas canvasPrincipal;

    public void voltar()
    {
        canvasPrincipal.enabled = true;
        canvasconfig.enabled = false;
    }

    public void ativar()
    {
        canvasconfig.enabled = true;
        canvasPrincipal.enabled = false;
    }
}

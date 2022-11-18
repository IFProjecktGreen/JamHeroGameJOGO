using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtVoltarTeclas : MonoBehaviour
{
    public Canvas canvasTeclas;
    public Canvas canvasConfig;
    
    public void Voltar()
    {
        canvasConfig.enabled = true;
        canvasTeclas.enabled = false;
    }

    public void ativar()
    {
        canvasTeclas.enabled = true;
        canvasConfig.enabled = false;
    }
}

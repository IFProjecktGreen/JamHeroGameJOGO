using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using TMPro;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public Canvas canvas;
    public TextMeshProUGUI missoesTXT;

    private float contdown = 7f;

    void Update()
    {
        contdown -= Time.deltaTime;
        if(contdown >= 3)
        {
            missoesTXT.text = "Aperte E para Interagir com o cenário e Pessoas";
        }
        else if(contdown < 3 && contdown > 0)
        {
            missoesTXT.text = "Aperte ESC para pausar";
        }
        else
        {
            canvas.enabled = false;
        }
    }
}

using TMPro;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public Canvas canvas;
    public TextMeshProUGUI missoesTXT;

    private float contdown = 12f;

    void Update()
    {
        contdown -= Time.deltaTime;
        if(contdown >= 6)
        {
            missoesTXT.text = "Aperte E para Interagir com o cenário e Pessoas";
        }
        else if(contdown < 6 && contdown > 0)
        {
            missoesTXT.text = "Aperte ESC para pausar";
        }
        else
        {
            canvas.enabled = false;
        }
    }
}

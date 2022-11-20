using TMPro;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public Canvas canvas;
    public TextMeshProUGUI missoesTXT;
    public GameObject panel;
    public TextMeshProUGUI fala;

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
            panel.SetActive(false);
            fala.enabled = false;
            missoesTXT.text = "Aperte ESC para pausar";
        }
        else
        {
            canvas.enabled = false;
        }

        if(paredes.ativo == true)
        {
            panel.SetActive(false);
            fala.enabled = false;
        }
    }
}

using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trig : MonoBehaviour
{

    private float contdown = 6f;
    public TextMeshProUGUI omi;
    public TextMeshProUGUI textMeshProUGUI;
    public TextMeshProUGUI muie2;
    private bool passou = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        textMeshProUGUI.enabled = true;
        passou = true;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("scene 06");
    }

    private void Update()
    {
        if (passou)
        {
            contdown -= Time.deltaTime;
            if(contdown <= 4)
            {
                omi.enabled = true;

            }

            if (contdown <= 2)
            {
                textMeshProUGUI.enabled = false;
                muie2.enabled = true;
            }
        }
    }
}

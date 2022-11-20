using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demonio : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] SpriteRenderer visiocue;
    public CapsuleCollider2D capsuleCollider;
    private string CamaCena6;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && CamaCena6 == "true")
        {
            spriteRenderer.enabled = true;
            visiocue.enabled = true;
            capsuleCollider.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && CamaCena6 == "true")
        {
            spriteRenderer.enabled = false;
            visiocue.enabled = false;
            capsuleCollider.enabled = false;
        }
    }

    private void Update()
    {
        CamaCena6 = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("CamaCena6")).value;
    }
}

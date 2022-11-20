using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demonioCena4 : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;

    public Canvas canvas;
    private int contador = 0;
    public CapsuleCollider2D capsuleCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && contador < 1)
        {
            canvas.enabled = true;
            spriteRenderer.enabled = true;
            capsuleCollider.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && contador < 1)
        {
            canvas.enabled = false;
            spriteRenderer.enabled = false;
            capsuleCollider.enabled = false;
            contador ++;
        }
    }
}

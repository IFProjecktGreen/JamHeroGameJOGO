using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegouUrsinho : MonoBehaviour
{
    public SpriteRenderer visualPing;

    [SerializeField] private SpriteRenderer spriterenderer;

    [SerializeField] private string Urso;

    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Urso = ((Ink.Runtime.StringValue)dialogocontroler.GetInstance().GetVariableState("urso")).value;

        if (Urso == "true")
        {
            spriterenderer.enabled = false;
            visualPing.enabled = false;
        }
    }
}

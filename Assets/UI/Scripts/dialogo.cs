using UnityEngine;

public class dialogo : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualcue;
    [SerializeField] private TextAsset textAsset;

    [SerializeField] private bool proximo = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            proximo = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            proximo = false;
    }

    private void Awake()
    {
        visualcue.SetActive(false);
    }

    private void Update()
    {
        if (proximo && !dialogocontroler.GetInstance().dialogoIsOn)
        {
            visualcue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                dialogocontroler.GetInstance().InDialogueMode(textAsset);
            }
        }
        else
        {
            visualcue.SetActive(false);
        }
    }
}

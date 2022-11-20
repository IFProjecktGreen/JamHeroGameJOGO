using UnityEngine;
using Random = UnityEngine.Random;

public class Player : MonoBehaviour
{
    public float speed;
    private Vector2 movement;
    public AudioSource passosAudioSource;
    public AudioClip[] audioPassosClips; 

    public Vector2 _movement
    {
        get { return movement;}
        set { movement = value; }
    }

    private Rigidbody2D rid;
    
    private void Start()
    {
        rid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        OnInput();
        OnMove();

        if (dialogocontroler.GetInstance().dialogoIsOn)
        {
            rid.MovePosition(rid.position);
        }
        else
        {
            OnMove();
            OnInput();
        }
    }
    
    public void Passos()
    {
        passosAudioSource.PlayOneShot(audioPassosClips[Random.Range(0, audioPassosClips.Length)]);
    }

    #region Movement

    void OnInput()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    void OnMove()
    {
        rid.MovePosition(rid.position + movement * (speed * Time.fixedDeltaTime));
    }

    #endregion
}

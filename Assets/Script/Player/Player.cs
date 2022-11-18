using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Vector2 movement;

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

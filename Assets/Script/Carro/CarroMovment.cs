using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarroMovment : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rig;
    private Vector2 movement;
    private float valorInicial = 0;
    
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        Andar();
        Move();
    }

    #region Movment

    void Andar()
    {
        var y = transform.position.y + valorInicial++;
        movement = new Vector2(0, y);
    }
    
    void Move()
    {
        rig.MovePosition(rig.position + movement * (speed * Time.fixedDeltaTime));
    }

    #endregion
}

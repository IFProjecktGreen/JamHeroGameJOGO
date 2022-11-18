using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Player player;
    private Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogocontroler.GetInstance().dialogoIsOn)
        {
            anim.SetInteger("transition", 0);
        }
        else
        {
            OnMove();
        }
    }

    #region MyRegion

    void OnMove()
    {
        if (player._movement.sqrMagnitude > 0 && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetInteger("transition", 2);
        }
        
        else if (player._movement.sqrMagnitude > 0 && Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetInteger("transition", 3);
        }
        
        else if (player._movement.sqrMagnitude > 0 && Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetInteger("transition", 3);
            player.transform.Rotate(0, 180, 0);
        }
        
        else if (player._movement.sqrMagnitude > 0 && Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetInteger("transition", 1);
        }
        
        else
        {
            anim.SetInteger("transition", 0);
        }
        
        if (player._movement.x > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
        
        if (player._movement.x < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
    }
    
    #endregion
}

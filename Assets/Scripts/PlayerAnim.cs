using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Player player;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        onMove();
        onRun();
    }

    #region moviment

    void onMove()
    {
        if (player.direction.sqrMagnitude > 0)
        {
            if (player.isRolling)
            {
                anim.SetTrigger("isRoll");
            }
            else
            {
                anim.SetInteger("transition", 1);
            }
        }
        else
        {
            anim.SetInteger("transition", 0);
        }

        if (player.direction.x > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
        if (player.direction.x < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
        if (player.IsCutting == true)
        {
            anim.SetInteger("transition", 3);
        }
        if (player.IsDigging == true)
        {
            anim.SetInteger("transition", 4);
        }
        if (player.IsWatering == true)
        {
            anim.SetInteger("transition", 5);
        }
    }

    void onRun()
    {
        if (player.isRunning)
        {
            anim.SetInteger("transition", 2);
        }

    }
    #endregion
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] private float treeHealth;
    [SerializeField] private Animator anim;
    // Start is called before the first frame update

    public void OnHit()
    {
        treeHealth--;

        anim.SetTrigger("IsHit");

        if(treeHealth <= 0)
        {
            //cria o toco e instancia os drops
            anim.SetTrigger("IsCut");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("axe"))
        {
            OnHit();
        }
    }
}

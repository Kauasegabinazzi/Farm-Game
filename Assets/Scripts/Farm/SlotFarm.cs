using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SlotFarm : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRender;
    [SerializeField] private Sprite hole;
    [SerializeField] private Sprite carrot;

    [SerializeField] private int digAmout; // quantidade vezes de escavação
    private int initialDig;

    // Start is called before the first frame update
    void Start()
    {

        initialDig = digAmout;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnHit()
    {
        digAmout--;

        if (digAmout <= initialDig / 2)
        {
            spriteRender.sprite = hole;
        }

        //if (digAmout <= 0)
        //{
        //    //plantar cenoura
        //    spriteRender.sprite = carrot;
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("dig"))
        {
            OnHit();
        }
    }
}

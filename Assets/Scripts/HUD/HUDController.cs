using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    [SerializeField] private Image waterUI;
    [SerializeField] private Image woodUI;
    [SerializeField] private Image carrotUI;

    private PlayerItens playerItens;

    private void Awake()
    {
        playerItens = FindObjectOfType<PlayerItens>();
    }

    // Start is called before the first frame update
    void Start()
    {
        waterUI.fillAmount = 0f;
        woodUI.fillAmount = 0f;
        carrotUI.fillAmount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        waterUI.fillAmount = playerItens.currentWater / playerItens.WaterLimit1;
        woodUI.fillAmount = playerItens.TotalWood / playerItens.WoodLimit;
        carrotUI.fillAmount = playerItens.carrots / playerItens.CarrotLimit;
    }
}

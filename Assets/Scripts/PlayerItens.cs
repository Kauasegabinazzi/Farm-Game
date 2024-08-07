using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItens : MonoBehaviour
{
    [SerializeField] private int totalWood;
    public float currentWater;
    public int carrots;

    private float waterLimit;
    private float carrotLimit;
    private float woodLimit;

    public int TotalWood { get => totalWood; set => totalWood = value; }
    public float WaterLimit1 { get => waterLimit; set => waterLimit = value; }
    public float CarrotLimit { get => carrotLimit; set => carrotLimit = value; }
    public float WoodLimit { get => woodLimit; set => woodLimit = value; }

    void Start()
    {
        waterLimit = 50;
        woodLimit = 10;
        carrotLimit = 10;
    }

    public void WaterLimit(int water)
    {
        if (currentWater <= waterLimit)
        {
            currentWater += water;
        }
    }
}

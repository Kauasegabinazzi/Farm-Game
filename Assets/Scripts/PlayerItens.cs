using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItens : MonoBehaviour
{
    [SerializeField] private int totalWood;
    public int currentWater;
    public int waterLimit;

    public int TotalWood { get => totalWood; set => totalWood = value; }

    void Start()
    {
        waterLimit = 50;
    }

    public void WaterLimit(int water)
    {
        if(currentWater <= waterLimit)
        {
            currentWater += water;
        }
    }
}

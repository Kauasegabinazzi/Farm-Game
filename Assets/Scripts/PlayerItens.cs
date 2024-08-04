using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItens : MonoBehaviour
{
    [SerializeField] private int totalWood;
    [SerializeField] private int currentWater;
    public int waterLimit = 50;

    public int TotalWood { get => totalWood; set => totalWood = value; }
    public int CurrentWater { get => currentWater; set => currentWater = value; }

    public void WaterLimit(int water)
    {
        if(currentWater < waterLimit)
        {
            currentWater += water;
        }
    }
}

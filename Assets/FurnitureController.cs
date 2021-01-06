using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureController : MonoBehaviour
{
    public GameObject[] ChairArray;
    public GameObject[] TableArray;
    public GameObject[] SofaArray;
    public GameObject[] ArmchairArray;
    public GameObject[] LampArray;
    public GameObject[] NightstandArray;

    public static GameObject currentFurniture;

    public void SelectChair(int ModelNumber)
    {
        currentFurniture = ChairArray[ModelNumber];
    }

    public void SelectTable(int ModelNumber)
    {
        currentFurniture = TableArray[ModelNumber];
    }

    public void SelectSofa(int ModelNumber)
    {
        currentFurniture = SofaArray[ModelNumber];
    }

    public void SelectArmchair(int ModelNumber)
    {
        currentFurniture = ArmchairArray[ModelNumber];
    }

    public void SelectLamp(int ModelNumber)
    {
        currentFurniture = LampArray[ModelNumber];
    }

    public void SelectNightstand(int ModelNumber)
    {
        currentFurniture = NightstandArray[ModelNumber];
    }

}

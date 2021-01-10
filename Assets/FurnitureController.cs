using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureController : MonoBehaviour
{
    public GameObject[] ChairArray;
    public GameObject[] TableArray;
    public GameObject[] SofaArray;
    public GameObject[] ArmchairArray;
    public GameObject[] NightstandArray;
    
    public static GameObject СurrentFurniture;
    public static GameObject[] СurrentCategory;


    public void SelectCategory(int currentCategory)
    {
        switch (currentCategory)
        {
            case 0:
                СurrentCategory = ChairArray;
                break;
            case 1:
                СurrentCategory = TableArray;
                break;
            case 2:
                СurrentCategory = SofaArray;
                break;
            case 3:
                СurrentCategory = ArmchairArray;
                break;
            case 4:
                СurrentCategory = NightstandArray;
                break;
        }
    }

    public void SelectModel(int modelNumber)
    {
        СurrentFurniture = СurrentCategory[modelNumber];
    }

}

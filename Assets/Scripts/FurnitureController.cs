using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureController : MonoBehaviour
{
    [SerializeField] private GameObject[] _chairArray;
    [SerializeField] private GameObject[] _tableArray;
    [SerializeField] private GameObject[] _sofaArray;
    [SerializeField] private GameObject[] _armchairArray;
    [SerializeField] private GameObject[] _nightstandArray;
    
    public static GameObject СurrentFurniture;
    private GameObject[] _currentCategory;


    public void SelectCategory(int selectedCategory)
    {
        switch (selectedCategory)
        {
            case 0:
                _currentCategory = _chairArray;
                break;
            case 1:
                _currentCategory = _tableArray;
                break;
            case 2:
                _currentCategory = _sofaArray;
                break;
            case 3:
                _currentCategory = _armchairArray;
                break;
            case 4:
                _currentCategory = _nightstandArray;
                break;
        }
    }

    public void SelectModel(int modelNumber)
    {
        СurrentFurniture = _currentCategory[modelNumber];
    }
}

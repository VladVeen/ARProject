using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObject : MonoBehaviour
{
    [SerializeField] private GameObject GroundPlaneStage;

    public void PutObject()
    {
        GameObject newObject = Instantiate(FurnitureController.currentFurniture) as GameObject;
        newObject.transform.SetParent(GroundPlaneStage.transform, false);
    }
}

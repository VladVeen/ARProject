using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowObjectScene : MonoBehaviour
{
    [SerializeField] private GameObject GroundPlaneStage;

    public void PutObject()
    {
        GameObject newObject = Instantiate(FurnitureController.СurrentFurniture) as GameObject;
        newObject.transform.SetParent(GroundPlaneStage.transform, false);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

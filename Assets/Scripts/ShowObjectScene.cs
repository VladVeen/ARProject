using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowObjectScene : MonoBehaviour
{
    [SerializeField] private GameObject _groundPlaneStage;
    private GameObject _currentObject;
    private Quaternion _yRotation;

    private void Update()
    {
        RotationObject();
    }

    public void PutObject()
    {
        GameObject newObject = Instantiate(FurnitureController.СurrentFurniture) as GameObject;
        newObject.transform.SetParent(_groundPlaneStage.transform, false);

        _currentObject = newObject;
    }

    private void RotationObject()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                _yRotation = Quaternion.Euler(0f, -touch.deltaPosition.x * 0.1f, 0f);
                _currentObject.transform.rotation = _yRotation * _currentObject.transform.rotation;
            }
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


}

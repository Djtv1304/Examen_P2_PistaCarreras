using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject mainCamera;
    public GameObject secondCamera;
    public GameObject thirdCamera;


    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            CameraOne();
        }

        if (Input.GetKeyDown("2"))
        {
            CameraTwo();
        }

        if (Input.GetKeyDown("3"))
        {
            CameraThree();
        }
    }

    void CameraOne()
    {
        mainCamera.SetActive(true);
        secondCamera.SetActive(false);
        thirdCamera.SetActive(false);
    }

    void CameraTwo()
    {
        thirdCamera.SetActive(false);
        secondCamera.SetActive(true);
        mainCamera.SetActive(false);
    }

    void CameraThree()
    {
        thirdCamera.SetActive(true);
        secondCamera.SetActive(false);
        mainCamera.SetActive(false);
    }
}

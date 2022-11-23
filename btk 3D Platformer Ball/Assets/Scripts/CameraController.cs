using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform trannsformCam;
    public Vector3 offset;
    void Start()
    {
        
    }

    
    void Update()
    {
        this.transform.position = trannsformCam.position + offset;
    }
}

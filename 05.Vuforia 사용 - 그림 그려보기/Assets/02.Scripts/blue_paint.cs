using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue_paint : MonoBehaviour {

    public Transform ARCam;

    void Start()
    {
        ARCam = Camera.main.transform;
    }

    void Update()
    {
        transform.LookAt(ARCam);
    }
}

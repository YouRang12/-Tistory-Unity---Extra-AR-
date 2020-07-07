using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour {

    private Transform tr;
    public Transform targetTr;
    public float rotSpeed = 30.0f;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        tr.RotateAround(targetTr.position, Vector3.up, Time.deltaTime * rotSpeed);
    }
}


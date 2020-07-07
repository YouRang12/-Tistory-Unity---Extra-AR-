using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DroneCtl : MonoBehaviour {

    public GameObject markerGoal;
    //public GameObject destSprite;

    private Vector3 parentPos;
    private NavMeshAgent agent;

    void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        MoveToTarget();
    }

    void MoveToTarget()
    {
        if (markerGoal.activeSelf)
        {
            parentPos = markerGoal.transform.parent.position;
            agent.SetDestination(parentPos);
            //destSprite.transform.position = new Vector3(parentPos.x, 0, parentPos.z);
        }
    }
}


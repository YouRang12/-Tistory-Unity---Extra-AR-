using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    LineRenderer line;

	void Start ()
    {
        line = GetComponent<LineRenderer>();
        line.startWidth = 0.05f;
        line.endWidth = 0.05f;
	}
	
	void Update ()
    {
        line.SetPosition(0, transform.parent.position);
        line.SetPosition(1, new Vector3(transform.parent.position.x,
                                        0, transform.parent.position.z));
	}
}


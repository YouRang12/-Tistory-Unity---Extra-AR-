using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour {

    public GameObject bluePaint;

	void Update()
    {
        if(Input.GetMouseButton(2) || Input.touchCount > 0 )
        {
            Instantiate(bluePaint, transform.position, transform.rotation);
        }
    }
}

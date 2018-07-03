using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void MoveCube()
    {
        transform.Translate(transform.forward * 0.1f);
    }

    void RotateCube()
    {
        transform.Rotate(transform.up * 1.1f);
    }

    // Update is called once per frame
    void Update () {
        RotateCube();	
	}
}

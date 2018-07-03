using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

    public string StartText;
    public string UpdateText;

	// Use this for initialization
	void Start () {
        Debug.Log(StartText);
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(UpdateText);
	}
}

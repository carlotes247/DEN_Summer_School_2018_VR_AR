using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles collisions
/// </summary>
public class CollisionChecker : MonoBehaviour {

    /// <summary>
    /// The tag that we will compare our collision against
    /// </summary>
    public string TagToCompare;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        // If the object we collided with has the tag we want...
        if (collision.gameObject.CompareTag(TagToCompare))
        {
            // We run our logic!
        }
    }
}

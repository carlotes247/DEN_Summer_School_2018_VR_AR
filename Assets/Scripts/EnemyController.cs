using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles enemy logic
/// </summary>
public class EnemyController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Called when entering a collision
    private void OnCollisionEnter(Collision collision)
    {
        // If the object we collide is the player...
        if (collision.gameObject.GetComponent<PlayerController>())
        {
            // We destroy this object
            Destroy(this.gameObject);
        }
    }

}

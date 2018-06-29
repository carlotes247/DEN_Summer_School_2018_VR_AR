using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles enemy logic
/// </summary>
public class EnemyController : MonoBehaviour
{
	public float MoveSpeed = 1f;
	
	private GameObject _thePlayer;

	// Use this for initialization
	void Start () {
		FindPlayer();
	}
	
	// Update is called once per frame
	void Update () {
		FacePlayer();
		MoveTowardsPlayer();
	}

	private void FindPlayer()
	{
		_thePlayer = FindObjectOfType<PlayerController>().gameObject;
	}

	private void FacePlayer()
	{
		transform.LookAt(_thePlayer.transform);
	}

	private void MoveTowardsPlayer()
	{
		this.GetComponent<Rigidbody>().AddForce(transform.forward * MoveSpeed);
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

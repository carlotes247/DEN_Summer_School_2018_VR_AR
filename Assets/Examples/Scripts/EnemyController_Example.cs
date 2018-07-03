using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles enemy logic
/// </summary>
public class EnemyController_Example : MonoBehaviour
{
	/// <summary>
	/// Public variable to set the enemy's movement speed
	/// </summary>
	public float MoveSpeed = 1f;
	/// <summary>
	/// Private variable to hold a reference to the player
	/// </summary>
	private GameObject _thePlayer;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start () {
		// Call function to locate the player in the scene
		FindPlayer();
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update () {
		// Call function to face towards the player
		FacePlayer();
		// Call function to move towards the player
		MoveTowardsPlayer();
	}

	/// <summary>
	/// Function to locate the player in the scene
	/// </summary>
	private void FindPlayer()
	{
		// Find the player in the scene
		_thePlayer = FindObjectOfType<PlayerController_Example>().gameObject;
	}
	
	/// <summary>
	/// unction to face towards the player
	/// </summary>
	private void FacePlayer()
	{
		// Face towards the player
		transform.LookAt(_thePlayer.transform);
	}

	/// <summary>
	/// Function to move towards the player
	/// </summary>
	private void MoveTowardsPlayer()
	{
		// Move the object forward
		this.GetComponent<Rigidbody>().AddForce(transform.forward * MoveSpeed);
	}

    

}

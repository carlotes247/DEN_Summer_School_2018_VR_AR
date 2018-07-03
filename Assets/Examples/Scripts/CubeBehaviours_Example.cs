using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls Cube Behaviours
/// </summary>
public class CubeBehaviours_Example : MonoBehaviour
{	
	/// <summary>
	/// Public variable to set the Cube's speed
	/// </summary>
	public float Speed = 0.3f;
	/// <summary>
	/// Private variable to hold the current direction of the movement
	/// </summary>
	public float Direction = 1;

	/// <summary>
	/// Function to rotate the cube
	/// </summary>
	void RotateCube()
	{
		// Perform rotation
		transform.Rotate(Vector3.up * Speed * 10f * Direction);
	}
	
	/// <summary>
	/// Function to move the cube
	/// </summary>
	void MoveCube()
	{
		// Perform movement 
		transform.Translate(Vector3.left * Speed * Direction);
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update () {
		// Call function to move the cube
		//MoveCube();
		// Call function to rotate the cube
		RotateCube();
	}
}

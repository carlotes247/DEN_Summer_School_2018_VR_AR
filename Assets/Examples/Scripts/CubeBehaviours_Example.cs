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
	private float _direction = 1;

	/// <summary>
	/// Function to rotate the cube
	/// </summary>
	void RotateCube()
	{
		// If the rotation is above the threshold
		if (transform.rotation.y > 150.0f)
		{
			// Switch direction
			_direction = -1;
		}
		// If the rotation is below the threshold
		else if (transform.rotation.y < -150.0f)
		{
			// Switch direction
			_direction = 1;
		}
		// Perform rotation
		transform.Rotate(Vector3.up * Speed * 10f * _direction);
	}
	
	/// <summary>
	/// Function to move the cube
	/// </summary>
	void MoveCube()
	{
		// If cube X position is above the threshold
		if (transform.position.x > 5.0f)
		{
			// Switch direction
			_direction = -1;
		}
		// If cube X position is below the threshold
		else if (transform.position.x < -5.0f)
		{
			// Switch direction
			_direction = 1;
		}
		// Perform movement 
		transform.Translate(Vector3.left * Speed * _direction);
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update () {
		// Call function to move the cube
		MoveCube();
		// Call function to rotate the cube
		RotateCube();
	}
}

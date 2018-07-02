using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviours_Example : MonoBehaviour
{	
	public float Speed = 0.3f;
	private float _direction = 1;

	void RotateCube()
	{
		if (transform.rotation.y > 150.0f)
		{
			_direction = -1;
		}
		else if (transform.rotation.y < -150.0f)
		{
			_direction = 1;
		}
		transform.Rotate(Vector3.up * Speed * 10f * _direction);
	}
	
	void MoveCube()
	{
		if (transform.position.x > 5.0f)
		{
			_direction = -1;
		}
		else if (transform.position.x < -5.0f)
		{
			_direction = 1;
		}
		transform.Translate(Vector3.left * Speed * _direction);
	}
	
	// Update is called once per frame
	void Update () {
		MoveCube();
		RotateCube();
	}
}

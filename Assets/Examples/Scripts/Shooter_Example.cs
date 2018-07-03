using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Shoot bullets
/// </summary>
public class Shooter_Example : MonoBehaviour {

	/// <summary>
	/// Reference to the bullet prefab to be shot
	/// </summary>
    public GameObject Bullet;
	/// <summary>
	/// Reference to the location and rotation where bullets will be spawned from
	/// </summary>
	public GameObject Gun;
	/// <summary>
	/// Public variable to set the force that the bullet will be fired with
	/// </summary>
	public float BulletForce;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
		// Parent the gun object to whichever camera is the main camera in the scene
		Gun.transform.parent = Camera.main.gameObject.transform;
		// Reset the rotation of the gun to zero
		Gun.transform.rotation = new Quaternion(0,0,0,0);
	}
	
	/// <summary>
	/// Function to fire the bullets
	/// </summary>
	void FireBullet()
	{
		// Create the new bullet object
		GameObject newBullet = Instantiate(Bullet, Gun.transform.position , Gun.transform.rotation);
		// Add a force to the bullet object so that it will be projected away from the gun
		newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * BulletForce, ForceMode.Impulse);
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update () {
		// If there is a click from the left mouse button or a tap on the touch screen
		if (Input.GetMouseButtonDown(0))
		{
			// Call the function to fire a bullet
			FireBullet();
		}
	}
}

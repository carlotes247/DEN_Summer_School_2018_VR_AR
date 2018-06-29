using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject Bullet;
	public Transform Gun;
	public float BulletForce;

	void Start()
	{
//		FireBullet();
	}
	
	void FireBullet()
	{
		Gun = Camera.main.transform;
		GameObject newBullet = Instantiate(Bullet, Gun.position + Gun.transform.forward, Gun.rotation);
		newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * BulletForce, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			FireBullet();
		}
	}
}

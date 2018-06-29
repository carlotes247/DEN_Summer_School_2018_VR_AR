using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject Bullet;
	public GameObject Gun;
	public float BulletForce;

	void Start()
	{
//		FireBullet();
		Gun.transform.parent = Camera.main.gameObject.transform;
		Gun.transform.rotation = new Quaternion(0,0,0,0);
	}
	
	void FireBullet()
	{
		GameObject newBullet = Instantiate(Bullet, Gun.transform.position + Gun.transform.forward, Gun.transform.rotation);
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

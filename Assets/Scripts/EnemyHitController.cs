using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitController : MonoBehaviour
{
	public int ScoreValue = 100;
	public int Damage = 10;
	
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Hit()
	{
		FindObjectOfType<UIManager>().AddScore(ScoreValue);
			// We destroy this object
			Destroy(this.gameObject);

	}

	// Called when entering a collision
	void OnCollisionEnter(Collision collision)
	{
//		print("test");
		if (collision.gameObject.GetComponent<BulletController>() == true)
		{
			Destroy(collision.gameObject);
			Hit();
		}
		
		// If the object we collide is the player...
		if (collision.gameObject.GetComponent<PlayerController>())
		{
			collision.gameObject.GetComponent<PlayerController>().DamagePlayer(Damage);
			FindObjectOfType<UIManager>().UpdateUI();
			Destroy(this.gameObject);
		}

	}
}

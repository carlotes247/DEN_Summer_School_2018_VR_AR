using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitController_Example : MonoBehaviour
{
    /// <summary>
    /// How many points the player gets when the enemy is killed
    /// </summary>
    public int ScoreValue = 100;
    /// <summary>
    /// Damage that the enemy inflicts to the player
    /// </summary>
	public int Damage = 10;
    /// <summary>
    /// Reference to the UI Manager
    /// </summary>
    private UIManager_Example m_UIManager;
	

	// Use this for initialization
	void Start () {
        m_UIManager = FindObjectOfType<UIManager_Example>();        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Hit()
	{
        if (m_UIManager != null)
        {
            m_UIManager.AddScore(ScoreValue);
        }
		// We destroy this object
		Destroy(this.gameObject);

	}

	// Called when entering a collision
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.GetComponent<BulletController_Example>() == true)
		{
			Destroy(collision.gameObject);
			Hit();
		}
		
		// If the object we collide is the player...
		if (collision.gameObject.GetComponent<PlayerController_Example>())
		{
			collision.gameObject.GetComponent<PlayerController_Example>().DamagePlayer(Damage);
			FindObjectOfType<UIManager_Example>().UpdateUI();
			Destroy(this.gameObject);
		}

	}
}

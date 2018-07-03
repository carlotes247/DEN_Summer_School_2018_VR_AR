using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles the enemy getting hit
/// </summary>
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
	

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start () {
		// Locate and store a reference to the UI manager
        m_UIManager = FindObjectOfType<UIManager_Example>();        
    }
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update () {
		
	}

	/// <summary>
	/// Public function to hold behaviours for when the enemy gets hit
	/// </summary>
	public void Hit()
	{
		// If the UI manager has been set
        if (m_UIManager != null)
        {
	        // Send a message to the UI manager increasing the score
            m_UIManager.AddScore(ScoreValue);
        }
		// We destroy this object
		Destroy(this.gameObject);

	}

	/// <summary>
	/// Called when colliding with another object (which has a collider)
	/// </summary>
	/// <param name="collision"></param>
	void OnCollisionEnter(Collision collision)
	{
		// If the collision is with a bullet
		if (collision.gameObject.GetComponent<BulletController_Example>() == true)
		{
			// Destroy the bullet
			Destroy(collision.gameObject);
			// Call the function saying that this object was hit
			Hit();
		}
		
		// If the object we collide is the player...
		if (collision.gameObject.GetComponent<PlayerController_Example>())
		{
			// Tell the player that they have been hit and inflict some damage
			collision.gameObject.GetComponent<PlayerController_Example>().DamagePlayer(Damage);
			// If the UI manager has been set
			if (m_UIManager != null)
			{
				// Send a message to the UI manager telling it to update
				FindObjectOfType<UIManager_Example>().UpdateUI();
			}
			// Destroy this object
			Destroy(this.gameObject);
		}

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles player logic
/// </summary>
public class PlayerController_Example : MonoBehaviour
{
	/// <summary>
	/// Peference to the player's current health
	/// </summary>
	public int PlayerHealth = 10;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start () {
		
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update () {
		
	}

	/// <summary>
	/// Function to inflict damage upon the player
	/// </summary>
	/// <param name="damage"></param>
	public void DamagePlayer(int damage)
	{
		// Subtract the damage from the player's health
		PlayerHealth -= damage;
		// If the player's health has dropped below zero...
		if (PlayerHealth <= 0)
		{
			// Send a message to the GameManager telling it to end the game
			FindObjectOfType<GameManager_Example>().EndGame();
		}
	}
}

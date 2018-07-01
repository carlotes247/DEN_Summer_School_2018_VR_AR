﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles player logic
/// </summary>
public class PlayerController : MonoBehaviour
{

	public int PlayerHealth = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DamagePlayer(int damage)
	{
		PlayerHealth -= damage;
		if (PlayerHealth <= 0)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}

	private void UpdateUI()
	{
	
	}
}

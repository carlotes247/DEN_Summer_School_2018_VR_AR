﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles gameplay logic
/// </summary>
public class GameManager : MonoBehaviour {

    /// <summary>
    /// Flag that let us know if the game has started
    /// </summary>
    public bool GameStarted;

    /// <summary>
    /// The object that is in charge of spawning
    /// </summary>
    public SpawnController Spawner;

	// Use this for initialization
	void Start () {
        StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// Starts the Game
    /// </summary>
    private void StartGame()
    {
        // We start the game
        GameStarted = true;
        // If the spawner is not referenced...
        if (Spawner == null)
        {
            // We search for it in the scene
            Spawner = FindObjectOfType<SpawnController>();
        }
        // Start spawning enemies
        Spawner.StartSpawning(true);
    }

    /// <summary>
    /// Ends the Game
    /// </summary>
    private void EndGame()
    {
        // We end game 
        GameStarted = false;
        // Stop spawning
        Spawner.StartSpawning(false);
        // Quit application?
    }
}
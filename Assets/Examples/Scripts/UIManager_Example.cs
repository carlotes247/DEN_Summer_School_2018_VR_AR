using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

/// <summary>
/// Manages the game's UI
/// </summary>
public class UIManager_Example : MonoBehaviour {

    /// <summary>
    /// Reference to the score Text object in the scene
    /// </summary>
    public Text ScoreText;
    /// <summary>
    /// Reference to the health Text object in the scene
    /// </summary>
	public Text HealthText;
    /// <summary>
    /// Reference to the Game Over Text onject in the scene
    /// </summary>
	public GameObject GameOverText;
    /// <summary>
    /// Private variable containing the game score
    /// </summary>
	private int _gameScore = 0;
    /// <summary>
    /// Reference to the player component in the scene
    /// </summary>
    private PlayerController_Example m_Player;

	// Use this for initialization
	private void Start () {
        // Find the player reference when the game starts
        m_Player = FindObjectOfType<PlayerController_Example>();
        // Update UI to whatever values we have at start
        UpdateUI();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// Method to end the game
    /// </summary>
	public void EndGame()
	{
		// Activate the game over text
		GameOverText.SetActive(true);
	}

    /// <summary>
    /// Method to update the User Interface (UI)
    /// </summary>
	public void UpdateUI()
	{
        // If we have the references to our objects...
        if (ScoreText != null)
        {
	        // Update the score text
            ScoreText.text = "Score: " + _gameScore;
        }
        if (m_Player != null)
        {
	        // Update the health text
            HealthText.text = "Health: " + FindObjectOfType<PlayerController_Example>().PlayerHealth;
        }
    }

    /// <summary>
    /// Method to add score
    /// </summary>
    /// <param name="_newScore"></param>
	public void AddScore(int _newScore)
	{
		// Add an amount to the game's score
		_gameScore += _newScore;
		// Update the UI to reflect the new score
		UpdateUI();
	}
}

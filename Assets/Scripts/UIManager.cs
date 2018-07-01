using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour {
	
	public Text ScoreText;
	public Text HealthText;
	public GameObject GameOverText;
	private int _gameScore = 0;

	// Use this for initialization
	private void Start () {
		UpdateUI();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void EndGame()
	{
		GameOverText.SetActive(true);
	}

	public void UpdateUI()
	{
		ScoreText.text = "Score: " + _gameScore;
		HealthText.text = "Health: " + FindObjectOfType<PlayerController>().PlayerHealth;
	}

	public void AddScore(int _newScore)
	{
		_gameScore += _newScore;
		UpdateUI();
	}
}

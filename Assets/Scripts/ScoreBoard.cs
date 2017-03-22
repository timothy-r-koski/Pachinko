using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreBoard : MonoBehaviour {

	public Text scoreBoard;
	private string scoreText = "Score: ";
	private int score = 0;

	public void addScore(int points) {
		score += points;
		UpdateBoard ();
	}

	private void UpdateBoard() {
		scoreBoard.text = scoreText + score;
	}

}

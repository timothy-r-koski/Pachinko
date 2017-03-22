using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointBox : MonoBehaviour {

	public int pointValue;
	public ScoreBoard scoreboard;

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Ball") {
			GameObject.Destroy(collider.gameObject);
			scoreboard.addScore(pointValue);
		}
	}
}

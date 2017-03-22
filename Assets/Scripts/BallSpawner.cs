using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BallSpawner : MonoBehaviour {

	public GameObject ballPrefab;
	public List<GameObject> spawnPoints; 
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			SpawnBall();
		}
	}

	void SpawnBall()
	{
		GameObject ball = GameObject.Instantiate (ballPrefab);
		int randomSpawnIndex = Random.Range (0, spawnPoints.Count - 1);
		ball.transform.position = spawnPoints[randomSpawnIndex].transform.position;
	}
}

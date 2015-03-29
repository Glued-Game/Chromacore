﻿using UnityEngine;
using System.Collections;

public class MisticBallsGenerator : MonoBehaviour {

	public GameObject misticBall;

	public int minimumPoints;
	public int maximumPoints;

	public Vector2[] points;
	bool[] used;

	// Use this for initialization
	void Start () {
		int pointsToGenerate = (int)Random.Range (minimumPoints, maximumPoints+1);
		used = new bool[25];
		for (int i = 0; i <= points.Length; i++)
			used [i] = false;
		for (int i = 1; i <= pointsToGenerate; i++) {
			int index = Random.Range (0, points.Length);
			while (used[index] == true)
				index = Random.Range (0, points.Length);
			(Instantiate (misticBall, new Vector3(this.transform.position.x + points[index].x, this.transform.position.y + points[index].y, 0f), Quaternion.identity) as GameObject).transform.parent = this.transform;
			used[index] = true;
		}
	}
}
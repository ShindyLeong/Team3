﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		HealthBarScript.health -= 10f;
	}
}
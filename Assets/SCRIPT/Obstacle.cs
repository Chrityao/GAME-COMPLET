using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
	public GameManager gameManager;

	public void OnCollisionEnter2D(Collision2D collision)
	{
		
		gameManager.GameOver();
	}
}

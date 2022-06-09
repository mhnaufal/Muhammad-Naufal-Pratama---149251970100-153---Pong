using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
	public Collider2D ball;
	public bool isRight;
	public Score manager;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision == ball)
		{
			if (isRight)
			{
				manager.AddScoreKanan(1);
			}
			else
			{
				manager.AddScoreKiri(1);
			}
		}
	}
}

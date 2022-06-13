using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
	public int scoreKanan;
	public int scoreKiri;

	public int maxScore;

	public GerakanBola ball;

	public void AddScoreKanan(int increment)
	{
		scoreKanan += increment;

		if (scoreKanan >= maxScore)
		{
			GameOver();
		}
		ball.ResetBall();
	}

	public void AddScoreKiri(int increment)
	{
		scoreKiri += increment;

		if (scoreKiri >= maxScore)
		{
			GameOver();
		}
		ball.ResetBall();
	}

	public void GameOver()
	{
		SceneManager.LoadScene("MenuUtama");
	}
}

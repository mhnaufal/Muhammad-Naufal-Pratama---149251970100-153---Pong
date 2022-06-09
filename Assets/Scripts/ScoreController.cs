using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
	public Text scoreKanan;
	public Text scoreKiri;

	public Score manager;

	private void Update()
	{
		scoreKiri.text = manager.scoreKiri.ToString();
		scoreKanan.text = manager.scoreKanan.ToString();
	}
}

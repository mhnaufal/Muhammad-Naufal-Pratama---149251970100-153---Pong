using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedBar : MonoBehaviour
{
    public Collider2D ball; 
    public PowerUpManager manager;
	public GameObject raketKiri;
	public GameObject raketKanan;
    public int newSpeed = 12;

    private void OnTriggerEnter2D(Collider2D collision) 
    { 
        if (collision == ball) 
        {
            raketKiri.GetComponent<GerakanRaketKiri>().setSpeed(newSpeed);
            raketKanan.GetComponent<GerakanRaketKanan>().setSpeed(newSpeed);
            manager.RemovePowerUp(gameObject);
        }     
    } 
}

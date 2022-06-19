using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUExtendBar : MonoBehaviour
{
    public Collider2D ball; 
    public PowerUpManager manager;
	public GameObject raketKiri;
	public GameObject raketKanan;

    private void OnTriggerEnter2D(Collider2D collision) 
    { 
        if (collision == ball) 
        {
            raketKiri.gameObject.transform.localScale = new Vector3(0.4f, 4, 1);
            raketKanan.gameObject.transform.localScale = new Vector3(0.4f, 4, 1);
            manager.RemovePowerUp(gameObject);

            StartCoroutine(turnOffPowerUp());
        }     
    }

    IEnumerator turnOffPowerUp()
    {
        raketKanan.gameObject.transform.localScale = new Vector3(0.4f, 2, 1);
        raketKiri.gameObject.transform.localScale = new Vector3(0.4f, 2, 1);
        yield return new WaitForSeconds(5f);
    }
}

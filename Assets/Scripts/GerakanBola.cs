using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakanBola : MonoBehaviour
{
	public Vector2 speed;
	public Vector2 resetPosition;
	private Rigidbody2D rigid;
	GameObject raketKiri;
	GameObject raketKanan;

    // Start is called before the first frame update
    private void Start()
    {
		rigid = GetComponent<Rigidbody2D>();
		rigid.velocity = speed;
    }

	public void ResetBall()
	{
		raketKiri = GameObject.Find("RaketKiri");
        raketKiri.gameObject.transform.localScale = new Vector3(0.4f, 2f, 1f);
        raketKiri.GetComponent<GerakanRaketKiri>().setSpeed(6);
        
		raketKanan = GameObject.Find("RaketKanan");
        raketKanan.gameObject.transform.localScale = new Vector3(0.4f, 2f, 1f);
        raketKanan.GetComponent<GerakanRaketKanan>().setSpeed(6);

        rigid.velocity = new Vector2(5, 1.25f);
		transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
	}

    public void ActivatePUSpeedUp(float magnitude) 
    { 
        rigid.velocity *= magnitude; 
    }
}

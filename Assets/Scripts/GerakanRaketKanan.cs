using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakanRaketKanan : MonoBehaviour
{
	private Vector2 movement;
	private Rigidbody2D rigid;
	public int speed = 5;

    // Start is called before the first frame update
    void Start()
    {
		rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		MoveRaket(GetInput());
    }

	private Vector2 GetInput()
	{
		if (Input.GetKey(KeyCode.UpArrow)) 
		{
			return	movement = Vector2.up * speed;
		} 
		else if (Input.GetKey(KeyCode.DownArrow))
		{
			return movement = Vector2.down * speed;
		}

		return Vector2.zero;
	}

	private void MoveRaket(Vector2 movement)
	{
		// Debug.Log("SPEED: " + movement);
		rigid.velocity = movement;
	}

	public void setSpeed(int newSpeed)
	{
		speed = newSpeed;
	}
}

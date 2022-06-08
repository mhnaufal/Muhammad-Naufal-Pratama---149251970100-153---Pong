using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakanRaketKiri : MonoBehaviour
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
		if (Input.GetKey(KeyCode.W)) 
		{
			return	movement = Vector2.up * speed;
		} 
		else if (Input.GetKey(KeyCode.S))
		{
			return movement = Vector2.down * speed;
		}

		return Vector2.zero;
	}

	private void MoveRaket(Vector2 movement)
	{
		rigid.velocity = movement;
	}
}

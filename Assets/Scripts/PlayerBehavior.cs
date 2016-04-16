using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour
{
	public float Speed;
	public float JumpForce;
	private bool grounded;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey(KeyCode.A))
			MoveMethod("left");
		if (Input.GetKey(KeyCode.D))
			MoveMethod("right");
		if (Input.GetKey(KeyCode.Space) && grounded)
			MoveMethod("space");
	}

	void MoveMethod(string direction)
	{
		switch (direction)
		{
			case "left":
				transform.Translate(Vector2.left*Speed*Time.deltaTime);
				return;

			case "right":
				transform.Translate(Vector2.right*Speed*Time.deltaTime);
				return;

			case "space":
				GetComponent<Rigidbody2D>().AddForce(Vector2.up*JumpForce,ForceMode2D.Impulse);
				return;

			default:
				return;
        }

	}
}

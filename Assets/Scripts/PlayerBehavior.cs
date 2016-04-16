using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour
{
	public float Speed;
	public float JumpForce;
	public bool grounded;
	public LayerMask Mask;

	// Use this for initialization
	void Start ()
	{
		Mask = ~Mask;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey(KeyCode.A))
			MoveMethod("left");
		if (Input.GetKey(KeyCode.D))
			MoveMethod("right");
		/*if (Input.GetKey(KeyCode.Space))
			MoveMethod("space");*/
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

			/*case "space":
				var hit = Physics2D.Raycast(gameObject.transform.position, Vector2.down, 0.52f, Mask);
				if (hit.collider.CompareTag("Ground"))
				{ 
					GetComponent<Rigidbody2D>().AddForce(Vector2.up*JumpForce, ForceMode2D.Impulse);
				}
				return;*/

			default:
				return;
        }

	}
}

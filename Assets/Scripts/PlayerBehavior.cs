using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour
{
	public float Speed;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		MoveMethod(KeyCode.A, Vector2.left);
		MoveMethod(KeyCode.D, Vector2.right);
	}

	void MoveMethod(KeyCode key, Vector2 direction)
	{
		if (Input.GetKey(key))
		{
			transform.Translate(direction*Speed*Time.deltaTime);
		}
	}
}

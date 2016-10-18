using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	public static BallController instance;

	public float speed = 5;
	private Rigidbody rb;

	void Awake(){
		instance = this;
	}

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Debug.Log (moveHorizontal + " " + moveVertical);

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void Kill(){
	
	}
}

using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	private int jumpCounter;
	public GameObject obj;
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		if (Input.GetKeyDown (KeyCode.Space) && transform.position.y <10) {
			if(jumpCounter<2){
						rb.AddForce (Vector3.up * 300);
				jumpCounter++;
			}else if(transform.position.y <6)
				jumpCounter = 0;
				}


		Vector3 movement = new Vector3 (moveHorizontal, 0.0f , moveVertical);

		rb.AddForce (movement * speed);

		if(transform.position.y < -7)
			obj.transform.position = new Vector3(0.0f, 0.5f, 0.0f);
	}

	void OnTriggerEnter (Collider other){
		if (other.name == "Cube")
						obj.transform.position = new Vector3(0.0f, 0.5f, 0.0f);
		
		if (other.name == "Teleport")
						obj.transform.position = new Vector3 (-0.6664f, 8.02f, 70.2f);

		if (other.name == "Booster")
			rb.AddForce (Vector3.forward * 1000);

		if (other.name == "Next_Level")
			Application.LoadLevel (Application.loadedLevel + 1);
		if (other.name == "Win")
						Application.LoadLevel (2);
	
	}



}

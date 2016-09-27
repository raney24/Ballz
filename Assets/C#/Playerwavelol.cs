using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Playerwavelol : MonoBehaviour {

	// Use this for initialization

		public float speed;
		public Text levelCount;
		public Text winText;

		private Rigidbody rb;
		private int count;

		void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetlevelCount ();
		//winText.text = "";

	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Collectable1")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			SetlevelCount ();
		}
	}

	void SetlevelCount ()
	{
		levelCount.text = "Count: " + count.ToString ();
		Debug.Log(levelCount.text);
		if (count >= 1)
		{
		//	winText.text = "You Win!";
		}
	}
}

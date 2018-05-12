using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	MainPlayer _Player = new MainPlayer();
	Animator animator;
	Vector2 direction;
	float speed = 5f;

	void Start () {

		if (PlayerPrefs.GetInt ("Saved") == 1) {

			float pX = PlayerPrefs.GetFloat ("PlayerX");
			float pY = PlayerPrefs.GetFloat ("PlayerY");
			transform.position = new Vector2 (pX, pY);
		}

		animator = GetComponent<Animator>();
	}

	void Update () {

		Move ();
		GetInput ();
	}

	private void GetInput() {
		
		direction = Vector2.zero;

		if (Input.GetKey (KeyCode.W)) {
			direction += Vector2.up;
		}
		if (Input.GetKey (KeyCode.A)) {
			direction += Vector2.left;
		}
		if (Input.GetKey (KeyCode.S)) {
			direction += Vector2.down;
		}
		if (Input.GetKey (KeyCode.D)) {
			direction += Vector2.right;
		}
	}

	public void Move() {

		transform.Translate (direction * speed * Time.deltaTime / 3);

		if (direction.x != 0 || direction.y != 0) {

			AnimateMovement (direction);
		} 
		else {

			animator.SetLayerWeight (1, 0);
		}
	}

	public void AnimateMovement(Vector2 direction) {

		animator.SetLayerWeight (1, 1);

		animator.SetFloat ("x", direction.x);
		animator.SetFloat ("y", direction.y);
	}
}

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyPlayerController : MonoBehaviour {


	Vector3 velocity = Vector3.zero; 
	Rigidbody myRG;
	public float movSpeed = 1f; 
	public float flapS = 100f; 
	float deathCD;


	bool flapped = false; 
	Animator animator; 

	public bool isDead = false; 

	void Start(){
		animator = GetComponentInChildren<Animator> ();
		myRG = FindObjectOfType<Rigidbody> ();
		if (animator == null) {
			Debug.Log ("null anim");
		}
	}

	void Update(){
		if (isDead) {
			deathCD -= Time.deltaTime;
		}

		if (deathCD <= 0) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene ("Main");
			}
		}
	}

	void FixedUpdate(){
		if (isDead) {
			return; 
		}

		if (flapped) {
			myRG.AddForce (Vector3.right * movSpeed);

			animator.SetTrigger ("Flap");

			flapped = false;
		}

		if (myRG.velocity.y > 0) {
			transform.rotation = Quaternion.Euler (0, 0, 0);
		} else {
			float angle = Mathf.Lerp (0, -90, (-myRG.velocity.y / 3f));
			transform.rotation = Quaternion.Euler (0, 0, angle);
		}

	}

	void OnCollisionEnter(Collision other){
		animator.SetTrigger ("Death");
		isDead = true; 
		deathCD = 0.5f;
	}
}

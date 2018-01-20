using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PreLoader : MonoBehaviour {

	public Image logo;

	public float MR;
	public float CR;
	public int PS;
	public int dropD;
	public int timer;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject);	

		StartCoroutine (loadNextScene());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator loadNextScene(){
		
		logo.canvasRenderer.SetAlpha (0);
		
		logo.CrossFadeAlpha (255, 1500, true);

		yield return new WaitForSeconds(2f);

		logo.CrossFadeAlpha (0, 1f, true);

		yield return new WaitForSeconds (1.5f);
		SceneManager.LoadScene ("Options");
	}
}

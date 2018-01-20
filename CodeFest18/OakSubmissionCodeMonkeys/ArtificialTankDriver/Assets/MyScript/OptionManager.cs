using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionManager : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void continueScene(){
		loadVals ();
		SceneManager.LoadScene ("Main");
	}

	public void loadVals(){
		PreLoader pl = FindObjectOfType<PreLoader> ();
		pl.MR = float.Parse(GameObject.Find ("MRI").transform.GetChild(2).GetComponent<Text> ().text);
		pl.CR = float.Parse(GameObject.Find ("CRI").transform.GetChild(2).GetComponent<Text> ().text);
		pl.PS = int.Parse(GameObject.Find ("PSI").transform.GetChild(2).GetComponent<Text>().text);
		pl.dropD = GameObject.Find ("Dropdown").GetComponent<Dropdown>().value;
		pl.timer = int.Parse (GameObject.Find ("TI").transform.GetChild (2).GetComponent<Text> ().text);
		Debug.Log (pl.PS);
	}
}

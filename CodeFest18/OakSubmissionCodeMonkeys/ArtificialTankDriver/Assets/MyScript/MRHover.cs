using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MRHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		
		GameObject.Find ("Hint").GetComponent<Text> ().text = "Mutation is used to main genetic diversity from one generation to the next. It is analogous to biological mutation.";
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		GameObject.Find ("Hint").GetComponent<Text> ().text = "";
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CRHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		GameObject.Find ("Hint").GetComponent<Text> ().text = "Crossover is a genetic operator used to change the weight of random nodes in the network. It is integral for ensuring the network continues learning.";
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		GameObject.Find ("Hint").GetComponent<Text> ().text = "";
	}
}

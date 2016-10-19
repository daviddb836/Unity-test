using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	public Color defaultColour;
	public Color selectedColour;




	// Use this for initialization
	void Start () {
		
		
	}
	void onTouchDown() {
		GetComponent<Renderer> ().material.color = Color.red;
		}

	void onTouchUp() {
		GetComponent<Renderer> ().material.color = Color.red;
	}
	void onTouchStay() {
		GetComponent<Renderer> ().material.color = Color.red;
	}
	void onTouchExit() {
		GetComponent<Renderer> ().material.color = Color.red;
	}

}
		



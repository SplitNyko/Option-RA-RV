using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleLights : MonoBehaviour {

	public bool DefaultsOn = false;
	public string PlayerTag = "Player";
	public Animator LightsAnimator;

	public Text UIText;

	private bool isOn{
		get { return animator.GetBool("isOn"); }
		set { animator.SetBool("isOn", value); }
	}
	private bool justPressed = false;
	private Animator animator;
	
	void Start () {
		animator = GetComponent<Animator>();
		isOn = DefaultsOn;
	}
	
	private void OnTriggerStay(Collider other){
			if(other.CompareTag(PlayerTag)){
				UIText.text = "Appuyez sur le bouton action (Par défault: X) pour " + (LightsAnimator.GetBool("isOn") ? "éteindre les lumières" : "allumer les lumières");
				if(Input.GetButtonDown("ActionButton")){
					if(isOn != LightsAnimator.GetBool("isOn")){
						isOn = !isOn;
						LightsAnimator.SetBool("isOn", !isOn);
					} else {
						isOn = !LightsAnimator.GetBool("isOn");
						LightsAnimator.SetBool("isOn", isOn);
					}
				}	
			}
	}

	private void OnTriggerExit(Collider other){
		UIText.text = null;
	}
}

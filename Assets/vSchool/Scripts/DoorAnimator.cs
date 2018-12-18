using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimator : MonoBehaviour {

	public List<string> TagsActivation;
	bool isOpened;
	Animator animator;

	void Start () {
		animator = GetComponent<Animator>();
	}
	
	void Update () {

		if (isOpened)
		{
			animator.SetBool("isOpen", true);
		}
		else
		{
			animator.SetBool("isOpen", false);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (TagsActivation.Contains(other.tag))
		{
			isOpened = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (TagsActivation.Contains(other.tag))
		{
			isOpened = false;
		}
	}


}

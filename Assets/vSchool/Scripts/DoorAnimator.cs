using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimator : MonoBehaviour {

	public List<string> TagesActivation;
	bool isOpened;
	Animator animator;

	private IEnumerator coroutine;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();

		//start waitbefore closing as coroutine
		/*coroutine = waitBeforeClosing(2.0f);
		StartCoroutine(coroutine);*/
	}
	
	// Update is called once per frame
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
		if (TagesActivation.Contains(other.tag))
		{
			isOpened = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (TagesActivation.Contains(other.tag))
		{
			isOpened = false;
		}
	}

	/*IEnumerator waitBeforeClosing(float waitTime)
	{
		while (true)
		{
			yield return new WaitForSeconds(waitTime);
			isOpened = false;
			
		}
	}*/


}

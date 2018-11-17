/*
	This is a trigger that could be added to any Object 
	that might have the ability to do a dialouge.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeTrigger : MonoBehaviour {

	//An object from dialouge that can be customized
	public Dialouge dialouge;

	// A trigger for the dialouge
	public void TriggerDialouge(){
		FindObjectOfType<DialougeManager>().StartDialouge(dialouge);
	}
	
}

/*
	The reply class, is a class that carries the sentence of the reply,
	and the node link that it referes to, and a boolean that indicates
	if that reply is selected before or not.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Reply{

	[TextArea(2,4)]
	public string SentenceText;
	public int Nodelink;
	private bool isSelected = false;

	public void setIsSelected(bool value){
		isSelected = value;
	}

	public bool getIsSelected(){
		return isSelected;
	}
}

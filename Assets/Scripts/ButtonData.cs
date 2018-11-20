/* This component represents an object that carries an index, which will be attached
	for a button, that indicates which node should the dialouge navigates to.
*/ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonData : MonoBehaviour{

	public int NodeIndex;
	private int CurrentNodeIndex;
	private int CurrentReplyIndex;

	public void setCurrentNodeIndex( int index){
		CurrentNodeIndex = index;
	}
	public void setCurrentReplyIndex(int index){
		CurrentReplyIndex = index;
	}

	public int getCurrentNodeIndex(){
		return CurrentNodeIndex;
	}
	public int getCurrentReplyIndex(){
		return CurrentReplyIndex;
	}

}

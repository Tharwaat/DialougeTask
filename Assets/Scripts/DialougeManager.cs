//This manager is responsible for all the dialouge functionalities.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeManager : MonoBehaviour {

	//These attributes for showing the texts on the UI components
	public Text NameText;
	public Text	DialougeText;
	public Text ReplyOne;
	public Text ReplyTwo;
	

	// Use this for initialization
	void Start () {}

	// This function starts the dialouge
	public void StartDialouge(Dialouge dialouge){
		NameText.text = dialouge.name;
		ShowNode(dialouge.DialougeTreeNodes[0]);		
	}

	// public void GetNextSentence(TextNode node){
	// 	DialougeText.text = node.SentenceText;
	// 	if(node.replies.Length == 0){
	// 		EndDialouge();
	// 		return;
	// 	}		
	// }

	//Ends the dialouge
	public void EndDialouge(){ 
		Debug.Log("End of a Converstaion!.");
	}

	public void ShowNode(DialougeNode node){
		DialougeText.text = node.SentenceText;
		ReplyOne.text = node.replies[0].SentenceText;
		ReplyTwo.text = node.replies[1].SentenceText;
	}

	public void NavigateToNode(int index){
		
	}
}

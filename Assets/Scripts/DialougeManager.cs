//This manager is responsible for all the dialouge functionalities.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeManager : MonoBehaviour {

	//These attributes for showing the texts on the UI components
	public Text NameText; 
	public Text DialougeText;

	// Use this for initialization
	void Start () {}

	// This function starts the dialouge
	public void StartDialouge(Dialouge dialouge){
		NameText.text = dialouge.name;	
		ShowNode(dialouge.DialougeRootNode);		
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

	public void ShowNode(TextNode node){
		Debug.Log(node.SentenceText);
		//DialougeText.text = node.SentenceText;
		foreach (TextNode reply in node.replies){
			//Debug.Log(reply.SentenceText);
			ShowNode(reply);
		}
	}
}

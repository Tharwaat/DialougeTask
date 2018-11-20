//This manager is responsible for all the dialouge functionalities.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DialougeManager : MonoBehaviour {

	//These attributes for showing the texts on the UI components
	public Text NameText;
	public Text	DialougeText;
	public Text ReplyOne;
	public Text ReplyTwo;
	public Button ActionOne;
	public Button ActionTwo;

	//For keep Tracking the dialouge
	private Dialouge DialougeTracker;

	// This function starts the dialouge
	public void StartDialouge(Dialouge dialouge){
		/* Assigning a tracker that keeps tracking
		 the navigation between nodes
		*/
		DialougeTracker = dialouge;

		//Showing the name of the NPC, and the first dialouge node
		NameText.text = dialouge.name;		
		ShowNode(DialougeTracker.DialougeTreeNodes[0], 0);		
	}

	//Ends the dialouge
	public void EndDialouge(DialougeNode CurrentNode){ 

		//Showing the node text,the only first reply and clearing the other button
		DialougeText.text = CurrentNode.SentenceText;
		ReplyOne.text = CurrentNode.replies[0].SentenceText;
		ReplyTwo.text = "";

		//Assigning data to the first button
		ButtonData ButtonOne = (ButtonData) ActionOne.GetComponent("ButtonData");
		ButtonOne.NodeIndex = CurrentNode.replies[0].Nodelink;
	}

	public void ShowNode(DialougeNode node, int index){
		//Showing the node's sentence and it's replies
		DialougeText.text = node.SentenceText;

		ReplyOne.text = node.replies[0].SentenceText;
		// if(node.replies[0].getIsSelected()) ActionOne.interactable = false;
		// else ActionOne.interactable = true;

		ReplyTwo.text = node.replies[1].SentenceText;
		// if(node.replies[0].getIsSelected()) ActionTwo.interactable = false;
		// else ActionTwo.interactable = true;

		/* Assigning data to buttons */
		AssignButtonData(node, index);		
	}

	public void onClicked(){
		// Receiving the next node index, current node index, and the reply that the clicked button referes to
		ButtonData data = (ButtonData) EventSystem.current.currentSelectedGameObject.GetComponent("ButtonData");
		
		// Marking the clicked reply isChecked
		//MarkChecked(data.getCurrentNodeIndex(), data.getCurrentReplyIndex());

		/*
		 Dertecting if this path is at the end, i.e: the current node's replies
		 are not more than one.
		*/ 
		if(DialougeTracker.DialougeTreeNodes[data.NodeIndex].replies.Length == 1){
			EndDialouge(DialougeTracker.DialougeTreeNodes[data.NodeIndex]);
		}
		else{
			ShowNode(DialougeTracker.DialougeTreeNodes[data.NodeIndex], data.NodeIndex);
		}
		
	}


	/* This function defines a next node reference, current node index,
	and current reply index for each button.
	*/
	public void AssignButtonData(DialougeNode CurrentNode, int NodeIndex){
		ButtonData ButtonOne = (ButtonData) ActionOne.GetComponent("ButtonData");
		ButtonOne.NodeIndex = CurrentNode.replies[0].Nodelink;
		// ButtonOne.setCurrentNodeIndex(NodeIndex);
		// ButtonOne.setCurrentReplyIndex(0);
		
		ButtonData ButtonTwo = (ButtonData) ActionTwo.GetComponent("ButtonData");
		ButtonTwo.NodeIndex = CurrentNode.replies[1].Nodelink;
		// ButtonOne.setCurrentNodeIndex(NodeIndex);
		// ButtonOne.setCurrentReplyIndex(1);
	}

	// A function that marks a reply that it's selected before
	// public void MarkChecked(int NodeIndex, int ReplyIndex){
	// 	DialougeTracker.DialougeTreeNodes[NodeIndex].replies[ReplyIndex].setIsSelected(true);
	// }
}

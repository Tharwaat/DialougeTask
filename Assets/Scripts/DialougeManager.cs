using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeManager : MonoBehaviour {

	public Text NameText;
	public Text DialougeText;
	private Queue<string> sentences;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
	}

	public void StartDialouge(Dialouge dialouge){
		NameText.text = dialouge.name;
		
		sentences.Clear();
		foreach(string sentence in dialouge.sentences){
			sentences.Enqueue(sentence);
		}

		GetNextSentence();
	}

	public void GetNextSentence(){
		if(sentences.Count == 0){
			EndDialouge();
			return;
		}

		string sentence = sentences.Dequeue();
		DialougeText.text = sentence;
	}

	public void EndDialouge(){
		Debug.Log("End of a Converstaion!.");
	}
}

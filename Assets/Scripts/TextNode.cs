/*
	A dialouge tree is a set of nodes, each node has a sentence that
	the dialouger said, and a set of replies, that each reply is 
	a node itself.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class TextNode{

	[TextArea(2,6)]
	public string SentenceText;
	public TextNode[] replies;
}

/*
	A dialouge tree is a set of nodes, each node has a sentence that
	the dialouger said, and a set of replies, that each reply has 
	it's own text, and an index that referes to other node.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class DialougeNode{

	[TextArea(2,4)]
	public string SentenceText;
	public Reply[] replies;
}

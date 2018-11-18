/*	This is a component, that holds the name of the dialouger,
	and a tree of all the his sentences, and all possible replies
	for each sentence. 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialouge{

	public string name; // NPC name
	public DialougeNode[] DialougeTreeNodes; // Root of the dialouge tree
}

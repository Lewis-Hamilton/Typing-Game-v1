using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

	private static string[] wordList = {"This","is","the","best","game","ever","Jellyfish","NUT","Kosher","turquoise","gut","king","Butt","Discord","exuberance","hut","humongous","hotdog","phone"};

	public static string GetRandomWord ()
	{
		int randomIndex = Random.Range(0, wordList.Length);
		string randomWord=wordList[randomIndex];

		return randomWord;
	}

}

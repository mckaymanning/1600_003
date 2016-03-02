using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour 
{
	int pieceOfCandy = 0;
	public int totalCandy = 5;

	void OnGUI ()
	{
		while ((GUI.Button(new Rect(10, 10, 150, 100), "Oooh a piece of candy!")) && pieceOfCandy < totalCandy)

		{
			Debug.Log("You ate a piece of candy!");
			pieceOfCandy++;
		}
	}
}
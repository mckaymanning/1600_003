using UnityEngine;
using System.Collections;

public class ForeachLoop : MonoBehaviour
{

		void Start ()
	{
		string[] strings = new string[5];

		strings[0] = "Equipped Inventory:";
		strings[1] = "Hero Sword";
		strings[2] = "Power Gauntlet";
		strings[3] = "Trousers of Minor Doom";
		strings[4] = "Lucky Ring";

		foreach(string item in strings)
		{
			print (item);
		}
	}
}



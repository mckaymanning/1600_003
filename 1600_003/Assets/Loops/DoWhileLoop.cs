using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour 
{
	void Start ()
	{
		bool unlockedCell = false;

		do {
			print ("Your cell is locked");
		} while(unlockedCell == true);
	}				
}
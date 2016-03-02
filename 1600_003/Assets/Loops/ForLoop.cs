using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour
{
	public int newEnemies = 4;

	void Start ()
	{
		for(int i = 0; i < newEnemies; i++) 
		{
			Debug.Log ("A new enemy has entered the arena.");
		}
	}
}
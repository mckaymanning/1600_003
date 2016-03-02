using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour
{
	public float wifeMood = 50.0f;
	public float insincereThreshold = 60.0f;
	public float uninterestedThreshold = 40.0f;
	
	
	void Update ()
	{

			if (Input.GetKeyDown (KeyCode.Space))
				MoodTest ();
				ComplimentTest ();
			wifeMood -= Time.deltaTime * 5f;

	}
	

	void MoodTest ()
	{
		// If the coffee's temperature is greater than the hottest drinking temperature...
		if(wifeMood > insincereThreshold)
		{
			// ... do this.
			print("Your compliments are too often and seem insincere.");
		}
		// If it isn't, but the coffee temperature is less than the coldest drinking temperature...
		else if(wifeMood < uninterestedThreshold)
		{
			// ... do this.
			print("Your wife thinks you never compliment her.");
		}
		// If it is neither of those then...
		else
		{
			// ... do this.
			print("You're a great guy!.");
		}
	}

	void ComplimentTest ()
	{
		if (Input.GetKeyUp (KeyCode.Space)) {
			wifeMood +=Time.deltaTime +5f;
		}
			
		
	}
}
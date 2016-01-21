using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	private void Start()
	{
		gameObject.AddComponent<Movement> ();
		gameObject.AddComponent<PlayerStats> ();
	}


}

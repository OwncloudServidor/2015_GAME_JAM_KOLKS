using UnityEngine;
using System.Collections;

public class Morte : MonoBehaviour 
{

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.tag == "Player")
		{
			other.GetComponent<Player>().Morrer();
		}
	}
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}

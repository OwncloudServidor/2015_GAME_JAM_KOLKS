using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public GameObject posicaoInicio;

	public void Morrer()
	{
		transform.position = posicaoInicio.transform.position;
	}
	// Use this for initialization
	void Start () 
	{
		transform.position = posicaoInicio.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}

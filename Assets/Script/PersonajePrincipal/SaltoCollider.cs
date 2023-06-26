using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoCollider : MonoBehaviour
{
    public static bool suelo;
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		suelo = true;
	}
	
	private void OnTriggerExit2D(Collider2D collision)
	{
		suelo = false;
	}
}

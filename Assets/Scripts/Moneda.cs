using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
	[SerializeField] private int valor;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		var gameManager = FindObjectOfType<GameManager>();
		gameManager.AddPuntos(valor);
		Destroy(this.gameObject);
	}
}

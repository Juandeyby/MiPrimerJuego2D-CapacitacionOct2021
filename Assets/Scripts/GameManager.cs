using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	private int _puntos;
    [SerializeField] private TMP_Text _puntosUI;

    public void SetUIPuntos(int puntos)
	{
		_puntosUI.SetText("Puntos: " + puntos);
	}

	public void AddPuntos(int valor)
	{
		_puntos = _puntos + valor;
		SetUIPuntos(_puntos);
	}

	public void ExitGame()
	{
		Application.Quit();
	}
}

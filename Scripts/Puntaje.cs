using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textMesh;

    private void Start()
    {
        puntos = 0;
        textMesh = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        textMesh.text = puntos.ToString();
    }

    public float getPuntos()
    {
        return puntos;
    }

    public void SumarPuntos(float puntosEntrada)
    {
        puntos += puntosEntrada;
    }

    public void RestarPuntos(float puntosEntrada)
    {
        puntos -= puntosEntrada;
    }
}


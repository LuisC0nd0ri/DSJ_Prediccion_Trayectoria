using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recycle : MonoBehaviour
{
    //puntaje
    [SerializeField] private float puntosSumados;
    [SerializeField] private Puntaje puntaje;

    //sonido
    [SerializeField] private AudioClip sonido;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            puntaje.SumarPuntos(puntosSumados);
            Ball jugador = other.GetComponent<Ball>();

            //sonido de acierto
            ControladorSonidos.Instance.EjecutarSonido(sonido);
            
            other.transform.position = jugador.startPosition;
            jugador.DesactivateRb();
        }
    }
}

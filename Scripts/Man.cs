using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man : MonoBehaviour
{
    //puntaje
    [SerializeField] private float puntosRestados;
    [SerializeField] private Puntaje puntaje;

    //sonido
    [SerializeField] private AudioClip sonido;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            puntaje.RestarPuntos(puntosRestados);
            Ball jugador = other.GetComponent<Ball>();

            //sonido de acierto
            ControladorSonidos.Instance.EjecutarSonido(sonido);

            if(puntaje.getPuntos() < 0f)
            {
                Debug.Log("Salir...");
                FindObjectOfType<PerderUI>().MostrarPerder();
            }

            other.transform.position = jugador.startPosition;
            jugador.DesactivateRb();
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class PerderUI : MonoBehaviour
{
    public GameObject panelPerder;

    // Llama esto cuando el jugador pierde
    public void MostrarPerder()
    {
        panelPerder.SetActive(true);
        Time.timeScale = 0f; // Pausa el juego
    }

    public void ReiniciarPartida()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Salir()
    {
        Application.Quit();
    }
}

using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera[] cameras; // arrastra tus c�maras aqu� desde el Inspector
    private int currentCam = 0;

    void Start()
    {
        // Desactivar todas las c�maras, excepto la primera
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].enabled = (i == 0);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Desactivar c�mara actual
            cameras[currentCam].enabled = false;

            // Cambiar �ndice
            currentCam = (currentCam + 1) % cameras.Length;

            // Activar la nueva
            cameras[currentCam].enabled = true;
        }
    }
}

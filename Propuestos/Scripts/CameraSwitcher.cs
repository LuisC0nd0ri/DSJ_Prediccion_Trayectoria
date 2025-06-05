using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera[] cameras; // arrastra tus cámaras aquí desde el Inspector
    private int currentCam = 0;

    void Start()
    {
        // Desactivar todas las cámaras, excepto la primera
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].enabled = (i == 0);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Desactivar cámara actual
            cameras[currentCam].enabled = false;

            // Cambiar índice
            currentCam = (currentCam + 1) % cameras.Length;

            // Activar la nueva
            cameras[currentCam].enabled = true;
        }
    }
}

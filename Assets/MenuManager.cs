using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Función para recargar la escena actual
    public void RecargarEscena()
    {
        // Obtiene el nombre de la escena que está abierta ahora y la vuelve a cargar
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    // Función para salir del juego
    public void SalirDelJuego()
    {
        // Cierra la aplicación (solo funciona en el juego exportado .exe/.app)
        Application.Quit();
    }
}

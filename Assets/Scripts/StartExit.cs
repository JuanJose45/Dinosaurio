using UnityEngine;
using UnityEngine.SceneManagement;

public class INICIOJUEGO : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Juego1");
    }

    public void Salir()
    {
        Application.Quit();
    }
}


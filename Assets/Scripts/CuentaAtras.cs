using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountdownManager : MonoBehaviour
{
    [Header("Referencias a los textos")]
    public GameObject text3;
    public GameObject text2;
    public GameObject text1;
    public GameObject textGo;
   

    [Header("Fondo de la cuenta atrás")]
    public GameObject backgroundImage; // 👈 La imagen o panel que quieras mostrar de fondo

    [Header("Tiempos")]
    public float delay = 1f;     // Tiempo entre 3, 2 y 1
    public float goDelay = 2f;   // Tiempo que dura el "GO"

  public  void comenzar()
    {
        StartCoroutine(CountdownRoutine());
    }

    IEnumerator CountdownRoutine()
    {
        // Asegurar que todo empiece desactivado
        text3.SetActive(false);
        text2.SetActive(false);
        text1.SetActive(false);
        textGo.SetActive(false);
        if (backgroundImage != null)
            backgroundImage.SetActive(false);

        // Activar el fondo
        if (backgroundImage != null)
            backgroundImage.SetActive(true);

        // 3
        text3.SetActive(true);
        yield return new WaitForSeconds(delay);
        text3.SetActive(false);

        // 2
        text2.SetActive(true);
        yield return new WaitForSeconds(delay);
        text2.SetActive(false);

        // 1
        text1.SetActive(true);
        yield return new WaitForSeconds(delay);
        text1.SetActive(false);

        // GO!
        textGo.SetActive(true);
        yield return new WaitForSeconds(goDelay);
        textGo.SetActive(false);

        // Desactivar el fondo
        if (backgroundImage != null)
            backgroundImage.SetActive(false);

        // Aquí puedes iniciar el juego
        // Ejemplo: playerController.enabled = true;
    }
}
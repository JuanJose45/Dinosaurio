using TMPro;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    [SerializeField] float tiempo;
    [SerializeField] int minutos;
    [SerializeField] int segundos;
    [SerializeField] TMP_Text textoTiempo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        minutos = (int)tiempo / 60;
        segundos = (int)tiempo % 60;
        textoTiempo.text = minutos.ToString("D2") + ":" + segundos.ToString("D2");
    }






}

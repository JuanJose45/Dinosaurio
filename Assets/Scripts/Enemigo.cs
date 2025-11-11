using UnityEngine;

public class Elementocontrol : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionMinima;
    [SerializeField] Vector2 posicionInicial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Obtengo la cámara principal del juego, es decir,
        //la que tiene el tag Main Camera
        camara = Camera.main;
        //Calculo las coordenadas x, y de la esquina de abajo a la izquieda
        //de la camara
        posicionMinima = camara.ViewportToWorldPoint(Vector2.zero);
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Se mueve de forma automática hacia la izquierda 
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        //Si la posicion del elemento es más pequeña que la de la esquina
        if (transform.position.x < posicionMinima.x -2)
        {
            //Destruimos el elemento en 0.5 segundos
            transform.position = posicionInicial;


        }
    }
}
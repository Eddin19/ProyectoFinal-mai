using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerFlechas : MonoBehaviour
{
    float timer;
    public GameObject FlechaPrefabs;
    public float tiempoTotalGeneracion = 10f; // Tiempo total de generaci�n en segundos
    public int cantidadFlechas = 10; // Cantidad de flechas a generar
    public float intervaloGeneracionMinimo = 1f; // Intervalo m�nimo entre la generaci�n de flechas

    private float tiempoEntreFlechas;
    private float tiempoTranscurrido = 0f;
    private int flechasGeneradas = 0;
    private float tiempoUltimaGeneracion = 0f;
    void Start()
    {
        tiempoEntreFlechas = Mathf.Max(intervaloGeneracionMinimo, tiempoTotalGeneracion / cantidadFlechas);
    }

    // Update is called once per frame
    void Update()
    {
        if (flechasGeneradas < cantidadFlechas)
        {
            tiempoTranscurrido += Time.deltaTime;

            if (tiempoTranscurrido - tiempoUltimaGeneracion >= tiempoEntreFlechas)
            {
                GenerarFlecha();
                tiempoUltimaGeneracion = tiempoTranscurrido;
                flechasGeneradas++;
            }
        }
    }
    void GenerarFlecha()
    {
        float x = Random.Range(4f, 5f);
        var position = new Vector3(x, -2, 0);
        Quaternion rotation = Quaternion.Euler(0, 0, -90);
        GameObject flecha = Instantiate(FlechaPrefabs, position, rotation);
        flecha.transform.Rotate(0, 0, 180);
    }
}

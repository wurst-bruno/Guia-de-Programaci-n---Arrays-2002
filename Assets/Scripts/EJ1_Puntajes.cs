using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ1_Puntajes : MonoBehaviour
{
    [SerializeField]int[] puntajes = new int[10]; //esto crea 10 fields para cargar ints



    void Start()
    {
        Debug.Log("El mayor puntaje es " + ObtenerMayorPuntaje());
        Debug.Log("El nivel con menor puntaje es " + ObtenerMayorPuntaje());
        Debug.Log("El promedio es " + ObtenerPuntajePromedio());

    }


    void Update()
    {
        
    }

    int ObtenerMayorPuntaje()
    {
        int mayorPuntaje = 0;

        foreach (int puntaje in puntajes) //recorre cada puntaje
        {
            if (puntaje > mayorPuntaje)
            {
                mayorPuntaje = puntaje;
            }
            
        }

        return mayorPuntaje;
    }

    int ObtenerNivelDeMenorPuntaje()
    {
        int indiceNivelMenorPuntaje = 0;
        int menorpuntaje = 0;
        for(int i= 0;i<puntajes.Length;i++)
        {
            if (puntajes[i] < menorpuntaje )
            {
                menorpuntaje = puntajes[i];
                indiceNivelMenorPuntaje = i;
            }
        }

        return indiceNivelMenorPuntaje;
    }
    float ObtenerPuntajePromedio()
    {
        float promedio = 0;
        int suma = 0;

        foreach (int num in puntajes)
        {
            suma += num;
        }
        promedio = suma / puntajes.Length * 1.0f;


        return promedio;
    }
}

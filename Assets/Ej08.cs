﻿//Crear una variable entera que pueda ser modificada desde el Inspector.
//Suponiendo que el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente
//al valor de la variable “dia”. Si el día no está en el rango 
//permitido debe emitir por pantalla el mensaje de error "El día ingresado no es válido". 


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej08 : MonoBehaviour
{
    public int dia;

    // Start is called before the first frame update
    void Start()
    {
        switch (dia) //variable a analizar
        {
            case 1:
                Debug.Log("Domingo");
                break; //Terminar el caso

            case 2:
                Debug.Log("Lunes");
                break; //Terminar el caso

            case 3:
                Debug.Log("Martes");
                break; //Terminar el caso

            case 4:
                Debug.Log("Miercoles");
                break; //Terminar el caso

            case 5:
                Debug.Log("Jueves");
                break; //Terminar el caso

            case 6:
                Debug.Log("Viernes");
                break; //Terminar el caso

            case 7:
                Debug.Log("Sabado");
                break; //Terminar el caso

            default:
                Debug.Log("El día ingresado no es valido");
                break;


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

﻿//6.Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0
//en una variable llamada num1 y muestre un mensaje por pantalla indicando si el número es
//par o el número es impar. Deberá utilizar el operador “módulo” es el caracter %.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej06 : MonoBehaviour
{
    public int num1;
    int resto;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 == 0)
        {
            Debug.Log("El numero debe ser mayor a 0");
        }

        resto = num1 % 2;

        if (resto == 0)
        {
            Debug.Log( num1 + " es par");
        } else 
         {
            Debug.Log(num1 + " es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

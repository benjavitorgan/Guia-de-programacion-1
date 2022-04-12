//7.Realizá un programa que al ingresar por Inspector tres números enteros num1, num2 y
//num3, muestre el valor del mayor de todos.
//En caso de igualdad entre los tres imprimir &quot; Los números son iguales&quot;.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej07 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 > num2 && num1 > num3)
        {
            Debug.Log(num1 + " es el mayor");
        } else if (num2 > num1 && num2 > num3)
        {
            Debug.Log(num2 + " es el mayor");
        } else if (num1 == num2 && num2 == num3)
        {
            Debug.Log("Los numeros son iguales");
        } else if (num3 > num1 && num3 > num2)
        {
            Debug.Log(num3 + " es el mayor");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

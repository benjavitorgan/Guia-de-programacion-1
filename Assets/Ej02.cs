using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour
{
    public int num1 = 4;
    public int num2 = 5;
    // Start is called before the first frame update

//    Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5,
//    respectivamente, realice la operación correspondiente y muestre el resultado en pantalla:
//    a.Suma
//    b.Producto

    void Start()
    {
        Debug.Log ("Caso a. " + (num1 + num2));
        Debug.Log ("Caso b. " + num1 * num2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

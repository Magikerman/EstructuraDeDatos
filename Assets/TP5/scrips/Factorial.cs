using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factorial : MonoBehaviour {
    [SerializeField] int numero = 1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("el factorial de " + numero + " es: " + recurFactorial(numero));
    }

    public int recurFactorial(int Numero)
    {
        if (Numero > 1)
        {
            return (Numero * recurFactorial(Numero - 1));
        }
        else { return (Numero); }
    } 
        
}
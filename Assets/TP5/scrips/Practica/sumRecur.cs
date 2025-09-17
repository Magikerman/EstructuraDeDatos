using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumRecur : MonoBehaviour
{
    [SerializeField] private int valor1 = 1;
    [SerializeField] private int valor2 = 2;
    [SerializeField] private int valor3 = 3;
    [SerializeField] private int valor4 = 4;

    // Start is called before the first frame update
    void Start()
    {
        int[] ray = new int[4];
        ray[0] = valor1;
        ray[1] = valor2;
        ray[2] = valor3;
        ray[3] = valor4;
        Debug.Log(sumArray(ray, 0));
    }

    // Update is called once per frame
    private int sumArray(int[] n, int counter)
    {
        if (counter >= n.Length - 1)
        {
            Debug.Log("fin de recursividad");
            return n[counter];
        }
        else 
        {
            Debug.Log("entro en recursividad");
            return n[counter] + sumArray(n, counter + 1);
        } 
    }
}

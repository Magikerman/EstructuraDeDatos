using UnityEngine;
using TMPro;
using NUnit.Framework.Constraints;
using Unity.VisualScripting;

public class Manager : MonoBehaviour
{
    [SerializeField] private string Mystring;
    [SerializeField] private Factorial Factorial;
    [SerializeField] private XPiramid XPiramid;
    [SerializeField] private Fibonachi Fibonachi;
    [SerializeField] private PalindromeCheck PaC;
    [SerializeField] private sumAllBefore SAB;
    [SerializeField] private TextMeshProUGUI TM;
    public void SaveString(string str)
    {
        Mystring = str;
        Debug.Log(Mystring);
    }

    public void OnFactorial()
    {
        if (int.TryParse(Mystring, out var factor))
        {
            TM.text = "";
            TM.text += "el Factorial de "+ Mystring+" es "+ Factorial.recurFactorial(factor);

        }
    }

    public void OnFibonacci()
    {
        if (int.TryParse(Mystring, out var factor))
        {
            TM.text = "";
            TM.text += "la posicion número "+factor+" de la sequencia de Fibonacci es: " + Fibonachi.showFibonacci(factor,0,0,1);
        }
    }

    public void OnPalinCheck() 
    {
        TM.text = "";
        TM.text += PaC.palincheck(Mystring,0);
    }

    public void OnSAB()
    {
        if (int.TryParse(Mystring, out var factor))
        {
            TM.text = "";
            TM.text += "la suma de todos los numeros inferiores a "+Mystring+" es "+ SAB.SumAllBefore(factor,0);

        }
    }

    public void onPirX()
    {
        if (int.TryParse(Mystring, out var factor))
        {
            TM.text = "";
            TM.text += XPiramid.piramid(factor,1);
        }
    }
}

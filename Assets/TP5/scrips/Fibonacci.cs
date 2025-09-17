using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fibonachi : MonoBehaviour
{
    [SerializeField] int posicionALlegar = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(showFibonacci(posicionALlegar, 0, 0, 1));
    }
    public int showFibonacci(int posFibonachi, int posAct, int posPrev, int pos)
    {
        if (posFibonachi == 1)
        {
            return 0;
        }
        else if (posFibonachi == 2)
        {
            return 1;
        }
        else if (posAct < posFibonachi)
        {
            if (posFibonachi > 2 && posAct < 2)
            {
                posAct += 2;
            }
        return (showFibonacci(posFibonachi, posAct + 1, pos, posPrev + pos));

        }
        else
        {
            return pos;
        }
    }
}

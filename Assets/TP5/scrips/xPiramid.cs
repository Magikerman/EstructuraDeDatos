using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class XPiramid : MonoBehaviour
{
    [SerializeField] private int piramidSize = 3;

    private void Start()
    {
        Debug.Log(piramid(piramidSize, 1));
    }

    public string piramid(int Height,int layer)
    {
        int size = 1 + Height * 2;
        if (layer < Height) 
        {
            string gap = new string(' ' , 1 + layer);
            string X = new string('X', size - layer * 2);
            return (piramid(Height, layer + 1) + "\n" + gap + X + gap);
        }
        else
        {
            string gap = new string(' ', 1 + layer);
            string X = new string('X', size - layer * 2);
            
            return (gap + X + gap);
        }
    }
}

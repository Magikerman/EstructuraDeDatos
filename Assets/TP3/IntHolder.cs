using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntHolder : MonoBehaviour
{
    [SerializeField] private int value = 0;
    public int Value => value; 
}

using UnityEngine;
using TMPro;
using System;
using NUnit.Framework;
using System.Linq;
public class ListManager : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField]public MyLinkedList<string> myList = new MyLinkedList<string>();
    private string textList;
    [SerializeField] private TMP_Text countText;
    public int Count => myList.Count;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textList = "";
        for (int i = 0; i < myList.Count; i++)
        {
            if (i == myList.Count-1) { textList += myList[i]; }
            else { textList += myList[i] + ", "; }     
        }
        text.text = textList;

        countText.text = "Count: " + myList.Count.ToString();
    }

    public void AddE()
    {
        myList.Add("Esto");

    }
    public void AddA()
    {
        myList.Add("Aquello");
    }
    public void Clear()
    {
        myList.Clear();
    }
    public void RemoveE()
    {
        myList.Remove("Esto");
    }
    public void RemoveA()
    {
        myList.Remove("Aquello");
    }
    public void AddRange()
    {
        string[] myRange = { "Esto", "Aquello" };
        myList.AddRange(myRange);
    }

    public void RemoveAtSecond()
    {
        myList.RemoveAt(1);
    }
}

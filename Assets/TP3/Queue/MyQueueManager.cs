using UnityEngine;
using TMPro;
using System;
using NUnit.Framework;
using System.Linq;
public class MyQueueManager : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] public MyQueue<string> myQueue = new MyQueue<string>();
    private string textList;
    [SerializeField] private TMP_Text countText;
    public int Count => myQueue.Count;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textList = "";
        /*for (int i = 0; i < myQueue.Count; i++)
        {
            if (i == myQueue.Count - 1) { textList += myQueue; }
            else { textList += myQueue + ", "; }
        }*/
        textList = myQueue.Peek().ToString();
        text.text = textList;

        countText.text = "Count: " + myQueue.Count.ToString();
    }

    public void EnqueueE()
    {
        myQueue.Enqueue("Esto");

    }
    public void EnqueueA()
    {
        myQueue.Enqueue("Aquello");
    }
    public void Clear()
    {
        myQueue.Clear();
    }
    public void Dequeue()
    {
        myQueue.Dequeue();
    }
    public void Peek()
    {

    }
}

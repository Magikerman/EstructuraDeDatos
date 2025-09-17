using System.Collections.Generic;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
    private int storeMoney;

    private Dictionary<int, float> store = new Dictionary<int, float>();

    [SerializeField] private Vector2[] posArray;

    private int[] pos = new int[6];

    private Dictionary<int, RectTransform> items = new Dictionary<int, RectTransform>();

    public void AddToStore(int id, float price, RectTransform item)
    {
        store.Add(id, price);
        items.Add(id, item);
        for (int i = 0; i < pos.Length; i++)
        {
            if (pos[i] == 0)
            {
                pos[i] = id;
                break;
            }
        }
    }

    public void Start()
    {
        Sort.Selection(pos, 0);

        for (int i = 0;i < posArray.Length;i++)
        {
            items[pos[i]].localPosition = posArray[i];
        }
    }

    public float GetPrice(int id)
    {
        float price;
        bool yes = store.TryGetValue(id, out price);
        if (yes)
        {
            return price;
        }
        else 
        {
            Debug.Log("Error");
            return 999999f;
        }
    }

    public float GetSellPrice(int id)
    {
        float price;
        bool yes = store.TryGetValue(id, out price);
        if (yes)
        {
            return price * 0.8f;
        }
        else
        {
            Debug.Log("Error");
            return 0f;
        }
    }
}

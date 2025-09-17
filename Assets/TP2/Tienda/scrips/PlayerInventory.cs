using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI money;
    [SerializeField] private StoreManager shop;
    [SerializeField] private TextMeshProUGUI sellButton;

    private float myMoney = 1000;

    private Dictionary<int, int> inventory = new Dictionary<int, int>();
    private Dictionary<int, string> itemNames = new Dictionary<int, string>();

    private MyLinkedList<int> itemIds = new MyLinkedList<int>();

    private bool isSelling = false;
    public bool IsSelling => isSelling;

    public void InteractWithItem(int id)
    {
        if (!isSelling)
        {
            AddToInventory(id);
        }
        else
        {
            RemoveFromInventory(id);
        }
    }

    public void AddToInventory(int id)
    {
        var price = shop.GetPrice(id);
        if (myMoney >= price)
        {
            myMoney -= price;
            if (!inventory.ContainsKey(id))
            {
                inventory.Add(id, 0);
                itemIds.Add(id);
            }
            inventory[id]++;
        }
    }
    public void RemoveFromInventory(int id)
    {
        if (inventory.ContainsKey(id))
        {
            var price = shop.GetSellPrice(id);
            myMoney += price;
            inventory[id]--;
            if (inventory[id] <= 0)
            {
                inventory.Remove(id);
                itemIds.Remove(id);
            }
        }
    }

    public void AddName(int id, string name)
    {
        itemNames.Add(id, name);
    }

    public void ChangeSell()
    {
        isSelling = !isSelling;
        if (isSelling)
        {
            sellButton.text = "Buy";
        }
        else { sellButton.text = "Sell"; }
    }

    private void Update()
    {
        money.text = "Money: " + (Mathf.Round(myMoney * 100))/100 + "\n\n\n";
        if (itemIds.Count > 0)
        {
            for (int i = 0; i < itemIds.Count; i++)
            {
                money.text += "\n" + itemNames[itemIds[i]] + $": {inventory[itemIds[i]]}";
            }
        }
    }
}

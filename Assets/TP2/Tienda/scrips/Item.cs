using UnityEngine;
using TMPro;

public class Item : MonoBehaviour
{
    [SerializeField] private StoreManager shop;
    [SerializeField] private PlayerInventory player;

    [Header("Info")]
    [SerializeField] private int id;
    [SerializeField] private string itemName;
    [SerializeField] private float price;

    [Header("Display")]
    [SerializeField] private TextMeshProUGUI info;

    private void Awake()
    {
        shop.AddToStore(id, price, GetComponent<RectTransform>());
        player.AddName(id, itemName);
    }

    private void Update()
    {
        if (player.IsSelling)
        {
            info.text = itemName + "\nSell value: " + shop.GetSellPrice(id);
        }
        else
        {
            info.text = itemName + "\nPrice: " + price;
        }
    }

    public void SendInfo()
    {
        player.InteractWithItem(id);
    }
}

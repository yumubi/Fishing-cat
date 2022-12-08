using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMouted : MonoBehaviour
{
    public CatItem thisItem;
    public CatItemList itemList;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AddCatItem();
            Destroy(gameObject);
        }
    }

    public void AddCatItem()
    {
        if (!itemList.catItemList.Contains(thisItem))
        {
            itemList.catItemList.Add(thisItem);
        }

        else
        {
            thisItem.itemHeld++;
        }

        itemListManager.RefreshItem();
    }

}

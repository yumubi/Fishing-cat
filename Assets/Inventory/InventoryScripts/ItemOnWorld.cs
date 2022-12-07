using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//�ýŲ������ڵ�ǰ�����пɻ�ȡ�ĵ�����
public class ItemOnWorld : MonoBehaviour
{
    public Item thisItem;
    public Inventory playerInventory;//Ŀ�걳��



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            AddNewItem();
            Destroy(gameObject);
        }
    }

    public void AddNewItem()
    {
        if (!playerInventory.itemList.Contains(thisItem))
        {
            playerInventory.itemList.Add(thisItem);
            //InventoryManager.CreateNewItem(thisItem);
        }
        else
        {
            //����������Ĭ��������1
            thisItem.itemHeld += 1;
        }
        //ˢ�±���
        InventoryManager.RefreshItem(); 
    }
}

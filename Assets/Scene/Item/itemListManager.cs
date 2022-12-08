using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemListManager : MonoBehaviour
{
   
    static itemListManager instance;
    public CatItemList Bag;
    public GameObject slotGrid;
    public CatSlot slotPrefab;
    public Text itemInformation;

    private void Awake()
    {
        if (instance != null) Destroy(this);
        instance = this;
    }

    private void OnEnable()
    {
        RefreshItem();
        instance.itemInformation.text = "";
    }

    public static void UpdateItemDescription(string description)
    {
        instance.itemInformation.text = description;
    }

    public static void CreateItem(CatItem item)
    {
        Debug.Log("success");
        CatSlot newItem = Instantiate(instance.slotPrefab, instance.slotGrid.transform.position, Quaternion.identity);
        newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
        newItem.slotItem = item;
        newItem.slotImage.sprite = item.itemImage;
        newItem.slotNum.text = item.itemHeld.ToString();

    }


    public static void RefreshItem()
    {
        Debug.Log("hee");
        for(int i = 0; i < instance.slotGrid.transform.childCount; i++)
        {
            Debug.Log("aa");
            Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
        }

        for(int i = 0; i < instance.Bag.catItemList.Count; i++)
        {
            Debug.Log("ddd");
            CreateItem(instance.Bag.catItemList[i]);
        }

    }


}

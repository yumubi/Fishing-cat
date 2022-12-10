using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//������������������Canvas��
public class InventoryManager : MonoBehaviour
{


    public static Slot onChoosedItem;
    static InventoryManager instance;
    

    public Inventory Bag;
    public GameObject slotGrid;
    public Slot slotPrefab;
    public Text itemInformation;


    private void Awake()
    {
        if (instance != null) Destroy(this);
        instance = this;
    }

    private void OnEnable()
    {
        RefreshItem();
        //��������Ĭ��Ϊ��
        instance.itemInformation.text = "";
    }

    //���Ƶ���������Ϣ����ʾ
    public static void UpdateItemInfo(string itemDescription)
    {
        instance.itemInformation.text = itemDescription;
    }
    //��������в����ڸõ��ߣ����ڱ����������Ӹõ���
    public static void CreateNewItem(Item item)
    {
        Slot newItem = Instantiate(instance.slotPrefab, instance.slotGrid.transform.position, Quaternion.identity);
        newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
        newItem.slotItem = item;
        if (newItem.slotItem.itemHeld == 0) newItem.slotItem.itemHeld = 1;
        newItem.slotImage.sprite = item.itemImage;
        newItem.slotNum.text = item.itemHeld.ToString();
    }


    //���Ƶ�����Ŀ����ʾ�仯
    public static void RefreshItem()
    {
        //�ȴݻٰ������е���
        for(int i = 0; i < instance.slotGrid.transform.childCount; i++)
        {
            //if (instance.slotGrid.transform.childCount == 0) break;
            Destroy(instance.slotGrid.transform.GetChild(i).gameObject);
        }

        //������������
        for(int i = 0; i < instance.Bag.itemList.Count; i++)
        {
            CreateNewItem(instance.Bag.itemList[i]);
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//���߲�ۣ����Ƶ��ߵ��Զ����к��Զ�װ����߾��飬������slotԤ������
public class Slot : MonoBehaviour
{
    public Item slotItem;//
    public Image slotImage;
    public Text slotNum;

    //�����������ʾ������Ϣ
    public void ItemOnClicked()
    {
    
        InventoryManager.UpdateItemInfo(slotItem.itemInfo);
        InventoryManager.onChoosedItem = this;
        
    }
}

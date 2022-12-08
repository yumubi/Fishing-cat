using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatSlot : MonoBehaviour
{
    public CatItem slotItem;
    public Image slotImage;
    public Text slotNum;

    public void ItemOnClicked()
    {
        itemListManager.UpdateItemDescription(slotItem.itemInfo); ;
    }
}

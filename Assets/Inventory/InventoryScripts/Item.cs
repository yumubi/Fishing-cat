using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/New Item")]
public class Item : ScriptableObject
{
    public string itemName;//��������
    public Sprite itemImage;//����ͼƬ����
    public int itemHeld;//Ŀǰ���е�������
    public int itemId;
    [TextArea]
    public string itemInfo;//����������Ϣ

    public bool equip;//�����Ƿ��װ��
}

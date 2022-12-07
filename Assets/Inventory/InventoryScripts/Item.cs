using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/New Item")]
public class Item : ScriptableObject
{
    public string itemName;//��������
    public Sprite itemImage;//����ͼƬ����
    public int itemHeld;//Ŀǰ���е�������
    [TextArea]
    public string itemInfo;//����������Ϣ

    public bool equip;//�����Ƿ��װ��
}

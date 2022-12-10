using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SaveManager : MonoBehaviour
{
    /*
   �����ǻᷢ���ĸı����
   */

    public Inventory Bag;
    public Item sword;
    public Item shoes;
    public Item armor;
    /*
   �����ǲ��ᷢ���ĸı����
   */
    public  int[] itemHelds = new int[10];

    /*
   ������������һЩ����
   */
    public SaveManager saveManager = Instance;  //�洢���ݵĶ���(saveMangerԤ����)
    public int test = 0;           //���Ա���


    /*
    �����Ǻ�������
    */
    public static SaveManager Instance; //���õ���
    private void Awake()  //���õ���
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }
    private void Start()  //���õ���
    {
        saveManager = Instance;
        int BagSize = Bag.itemList.Count;
        int swordHeld = sword.itemHeld;
        int shoesHeld = shoes.itemHeld;
        int armorHeld = armor.itemHeld;
        itemHelds[0] = swordHeld;
        itemHelds[1] = shoesHeld;
        itemHelds[2] = armorHeld;
        

    }
    public void SaveGame()  //�洢���ݺ���
    {
        Debug.Log("���ݴ�����" + Application.persistentDataPath);  //������ݵĴ���λ��
        if (!Directory.Exists(Application.dataPath + "/game_SaveDate"))  //���û���ҵ����ݴ洢�ļ��ʹ���һ��
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/game_SaveDate");
        }
        BinaryFormatter formatter = new BinaryFormatter();  //�����Ʊ���
        FileStream file = File.Create(Application.persistentDataPath + "/game_SaveDate/save.txt"); //�ļ�
        var json = JsonUtility.ToJson(saveManager);  //��Ҫ�洢�ı���ת��Ϊjson
        formatter.Serialize(file, json);  //��jsonתΪ�����ƴ����ļ�
        file.Close();  //�����޸�
    }
    public void LoadGame()  //��ȡ���ݺ���
    {
        BinaryFormatter bf = new BinaryFormatter();
        if (File.Exists(Application.persistentDataPath + "/game_SaveDate/save.txt"))
        {
            FileStream file = File.Open(Application.persistentDataPath + "/game_SaveDate/save.txt", FileMode.Open);
            JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), saveManager);
            file.Close();
        }
    }



}

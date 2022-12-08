using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemList", menuName = "List/New List")]
public class CatItemList : ScriptableObject
{
   public List<CatItem> catItemList= new List<CatItem> ();
}

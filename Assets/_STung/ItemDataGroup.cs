using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
[CreateAssetMenu(fileName = "ItemDataGroup", menuName = "_STung/ItemDataGroup")]
public class ItemDataGroup : ScriptableObject
{
    private static ItemDataGroup intance;
    public static ItemDataGroup Intance
    {
        get
        {
            if (intance == null)
            {
                intance = Resources.Load<ItemDataGroup>("ItemDataGroup");
            }
            return intance;
        }
    }
    [SerializeField] List<ItemData> lstItemData;
    IEnumerable<ItemData> LstItemData => lstItemData;

    public Sprite GetSpriteByType(NormalItem.eNormalType itemType)
    {
        return lstItemData.Find(x => x.Type == itemType).Sprite;
    }
}

[System.Serializable]
public class ItemData
{
    [SerializeField] private NormalItem.eNormalType type;
    [SerializeField] private Sprite sprite;
    public NormalItem.eNormalType Type => type;
    public Sprite Sprite => sprite;
}
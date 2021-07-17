using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string name = "Sword";
    public int rarity = 2; // 0 = Common | 1 = Uncommon | 2 = Rare | 3 = Epic | 4 = Legendary //
    public int damage = 10;
    public float attackSpeed = 1.0f;
}


public class GameManager : MonoBehaviour
{
    public static GameManager Singleton;

    string header;
    string content;

    public Item[] itemList;
    [Space]
    public Tooltip tooltip;

    void Awake()
    {
        GameManager.Singleton = this;
    }

    public void ShowTooltip(int itemID)
    {
        // Reset Old Content And Header
        content = "";
        header = "";

        header = itemList[itemID].name;
        content += "<color=#878787>Damage: <color=#FF4C04>+" + itemList[itemID].damage + "</color>" + "\n";
        content += "<color=#878787>Attack Speed: <color=#FFE445>" + itemList[itemID].attackSpeed + "</color>" + "\n";

        switch (itemList[itemID].rarity)
        {
            case 0:
                //Common
                tooltip.headerField.color = new Color(192, 192, 192);
                break;
            case 1:
                //Uncommon
                tooltip.headerField.color = new Color(0, 255, 0);
                break;
            case 2:
                //Rare
                tooltip.headerField.color = new Color(0, 128, 255);
                break;
            case 3:
                //Epic
                tooltip.headerField.color = new Color(102, 0, 204);
                break;
            case 4:
                //Legendary
                tooltip.headerField.color = new Color(255, 153, 51);
                break;
        }

        tooltip.SetText(header, content);
        tooltip.gameObject.SetActive(true);
    }

    public void HideTooltip()
    {
        tooltip.gameObject.SetActive(false);
    }
}

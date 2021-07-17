using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public int itemID = 0;

    public void OnPointerEnter(PointerEventData eventData)
    {
        GameManager.Singleton.ShowTooltip(itemID);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GameManager.Singleton.HideTooltip();
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class ContainerItemGui : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText = null;
    [SerializeField] TextMeshProUGUI countText = null;
    private ContainerItem item = ContainerItem.None;

    public void SetItem(ContainerItem cItem)
    {
        this.item = cItem;
        nameText.text = cItem.item.GetName();
        countText.text = cItem.count.ToString();
    }

    public ContainerItem GetItem()
    {
        return item;
    }

    public void SetSelected()
    {
        EventSystem.current.SetSelectedGameObject(this.gameObject);
    }
}

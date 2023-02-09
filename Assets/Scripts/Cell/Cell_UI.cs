using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell_UI : MonoBehaviour
{
    [SerializeField] private Image backGroundImage;

    [SerializeField] private Image itemIcon;

    private CellValues _cellValues;

    private void Start()
    {
        _cellValues = GetComponent<CellValues>();
        UpdateUI();
    }

    private void UpdateUI()
    {
        itemIcon.sprite = _cellValues.cellItem.itemSprite;
        backGroundImage.color = _cellValues.cellItem.itemRarityColor;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellValues : MonoBehaviour
{
    public Item cellItem;

    private Cell_UI _cellUI;

    private void Awake()
    {
        _cellUI = GetComponent<Cell_UI>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(cellItem.itemName);
    }

    [ContextMenu("Set Last")]
    private void Test()
    {
        transform.SetAsLastSibling();
    }
}

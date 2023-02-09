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
}

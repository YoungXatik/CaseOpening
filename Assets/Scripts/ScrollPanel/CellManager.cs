using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(ItemDataBase))]
public class CellManager : MonoBehaviour
{
    #region Singleton

    public static CellManager Instance;

    private void Awake()
    {
        Instance = this;
        _itemDataBase = GetComponent<ItemDataBase>();
    }

    #endregion

    private ItemDataBase _itemDataBase;

    [SerializeField] private CellValues cellPrefab;
    
    [SerializeField] public List<CellValues> spawnedItems = new List<CellValues>();

    [SerializeField] private int itemListCount;

    [SerializeField] private Transform spawnPoint;

    private float accumulatedWeights;
    
    private void Start()
    {
        if (itemListCount > _itemDataBase.items.Count)
        {
            itemListCount = _itemDataBase.items.Count;
        }
        Calculate();
        SpawnRandomItems();
    }

    private void SpawnRandomItems()
    {
        for (int i = 0; i < itemListCount; i++)
        {
            Item item = _itemDataBase.items[GetItemIndex()];
            var spawnedItem =  Instantiate(cellPrefab, spawnPoint);
            spawnedItem.cellItem = item;
            spawnedItems.Add(spawnedItem);

        }
    }

    private int GetItemIndex()
    {
        var random = Random.Range(0f, 1f) * accumulatedWeights;

        for (int i = 0; i < _itemDataBase.items.Count; i++)
        {
            if (_itemDataBase.items[i].weight >= random)
            {
                return i;
            }
        }

        return 0;
    }
    
    private void Calculate()
    {
        accumulatedWeights = 0f;
        foreach (Item item in _itemDataBase.items)
        {
            accumulatedWeights += item.itemRarityPercent;
            item.weight = accumulatedWeights;
        }
    }
}

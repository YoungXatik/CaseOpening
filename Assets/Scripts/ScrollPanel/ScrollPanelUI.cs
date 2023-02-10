using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollPanelUI : MonoBehaviour
{
    [field: SerializeField] public Button startScrollPanelButton { get; private set; }

    [SerializeField] private RectTransform content;
    public void EnableButton()
    {
        startScrollPanelButton.interactable = true;
        Check();

    }
    [ContextMenu("test")]
    private void Check()
    {
        foreach (RectTransform child in content)
        {
            CellManager.Instance.CheckOpenedItem();
        }
    }
    
    public void DisableButton()
    {
        startScrollPanelButton.interactable = false;
    }
}

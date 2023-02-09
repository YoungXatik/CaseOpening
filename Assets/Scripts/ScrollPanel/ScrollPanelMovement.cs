using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollPanelMovement : MonoBehaviour
{
    public RectTransform scrollView;
    public float scrollSpeed;

    private void Update()
    {
        scrollView.transform.Translate(new Vector3(scrollSpeed,0,0));
    }
}

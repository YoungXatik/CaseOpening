using System;
using UnityEngine;
using DG.Tweening;
using Random = UnityEngine.Random;

public class ScrollPanelController : MonoBehaviour
{
    [SerializeField] private Transform scrollPanelTransform;
    private Vector3 _startScrollPanelPosition;
    
    [SerializeField] private float scrollPanelStartSpeed;
    [SerializeField] private float minStartSpeed, maxStartSpeed;
    
    [SerializeField] private float scrollPanelMovingTime;

    private ScrollPanelUI _scrollPanelUI;
    private float _scrollPanelSpeed;
    
    public bool IsMoving { get; private set; }

    private void Awake()
    {
        _scrollPanelUI = GetComponent<ScrollPanelUI>();
        _startScrollPanelPosition = scrollPanelTransform.position;
    }

    private void Update()
    {
        if (IsMoving)
        {
            scrollPanelTransform.transform.Translate(_scrollPanelSpeed, 0, 0);
        }
    }

    public void EnablePanelMovement()
    {
        scrollPanelStartSpeed = Random.Range(minStartSpeed, maxStartSpeed);
        scrollPanelTransform.position = _startScrollPanelPosition;
        IsMoving = true;
        _scrollPanelSpeed = scrollPanelStartSpeed;
        _scrollPanelUI.DisableButton();
        SlowDownScrollSpeed();
    }

    private void SlowDownScrollSpeed()
    {
        DOTween.To(x => _scrollPanelSpeed = x, scrollPanelStartSpeed, 0, scrollPanelMovingTime).SetEase(Ease.Linear)
            .OnComplete(
                delegate
                {
                    IsMoving = false;
                    _scrollPanelUI.EnableButton();
                });
    }
}

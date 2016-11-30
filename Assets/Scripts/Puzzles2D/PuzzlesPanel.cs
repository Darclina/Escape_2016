﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PuzzlesPanel : MonoBehaviour, IPointerClickHandler
{
    public float FadeInTime = 0.25f;
    public float FadeOutTime = 0.25f;
    private CanvasGroup m_canvasGroup;

    // Use this for initialization
    void Start()
    {
        m_canvasGroup = transform.GetComponent<CanvasGroup>();
        m_canvasGroup.alpha = 0f;
        m_canvasGroup.blocksRaycasts = false;
    }

    // Fade In
    public void BeginFadeIn()
    {
        if (m_canvasGroup.alpha != 0f)
        {
            Debug.Log("The canvas group is not hidden");
        }

        Animator CanvasAnimator = this.gameObject.GetComponent<Animator>();
        CanvasAnimator.Play("Show", 0, FadeInTime);
    }

    // Fade Out
    public void BeginFadeOut()
    {
        if (m_canvasGroup.alpha != 1f)
        {
            Debug.Log("The canvas group is not shown");
        }

        Animator CanvasAnimator = this.gameObject.GetComponent<Animator>();
        CanvasAnimator.Play("Hide", 0, FadeOutTime);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        transform.GetComponentInChildren<Puzzle>().EndPuzzle(false); ;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tutorial_Menu : MonoBehaviour
{
    public Transform tutorialPageHolder;
    public Transform[] pages;
    public int currentPage = 0;
    public TMP_Text pageCounter;
    private void Awake()
    {
        pages = new Transform[tutorialPageHolder.childCount];

        for (int i = 0; i < pages.Length; i++)
            pages[i] = tutorialPageHolder.GetChild(i);
    }

    private void OnEnable()
    {
        currentPage = 0;
        FlipPage(0);
    }


    public void FlipPage(int flipDirection)
    {
        currentPage += flipDirection;
        currentPage = Mathf.Clamp(currentPage, 0, pages.Length -1);

        for (int i = 0; i < pages.Length; i++)
            pages[i].gameObject.SetActive(false);

        pages[currentPage].gameObject.SetActive(true);

        string s = string.Format("{0}/{1}", (currentPage + 1), pages.Length);
        pageCounter.text = s;
    }
}

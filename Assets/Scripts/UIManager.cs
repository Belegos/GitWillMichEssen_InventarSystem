using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image[] imagesArray;

    public void AddItem(AItem item, int index)
    {
        Image img = imagesArray[index];
        img.color = item.m_UiData.UiColor;
    }
    public void RemoveItem(int index)
    {
        Image img = imagesArray[index];
        img.color = Color.blue;
    }
}
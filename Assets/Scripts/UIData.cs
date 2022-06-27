using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [CreateAssetMenu(fileName = "UIData", menuName = "ScriptableObjects/Item", order = 0)]
public class UIData : ScriptableObject
{
    public string UiName;
    public string UiDescription;
    public Color UiColor;

}

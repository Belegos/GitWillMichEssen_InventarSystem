using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AItem : MonoBehaviour
{
    public UIData m_UiData;
    [HideInInspector]
    public Player PlayerRef;

    public abstract void use();
    

    
}

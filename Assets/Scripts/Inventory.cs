using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private UIManager m_UIManagerRef;
    private AItem[] inventoryArray = new AItem[5];
    [HideInInspector] public Player playerRef;
    public int inHandIndex;

    private void Awake()
    {
        playerRef = GetComponent<Player>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            inHandIndex++;
            inHandIndex = inHandIndex % inventoryArray.Length;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            inHandIndex--;
            inHandIndex = inHandIndex % inventoryArray.Length;
            if(inHandIndex < 0)
            {
                inHandIndex = inventoryArray.Length - 1;
            }
        }
    }
    public bool AddItem(AItem item)
    {
        for (int i = 0; i < inventoryArray.Length; i++)
        {
            if (inventoryArray[i] is null) //"is" is a keyword that checks if the object is of the same type as the parameter.
                //Faster than == but can't be overloaded
            {
                inventoryArray[i] = item;
                item.PlayerRef = playerRef;
                m_UIManagerRef.AddItem(item, i);
                return true;
            }
        }
        return false;
    }

    public bool RemoveItem(AItem item)
    {
        for (int i = 0; i < inventoryArray.Length; i++)
        {
            if (inventoryArray[i] == item)
            {
                inventoryArray[i] = null;
                //m_UIManagerRef.RemoveItem(item, i);
                item.PlayerRef = playerRef;
                return true;
            }
        }
        return false;
    }

    public bool UseItem()
    {
        if (inventoryArray[inHandIndex] is null)
        {
            return false;
        }
        else
        {
            inventoryArray[inHandIndex].use();
            return true;
        }


    }
}
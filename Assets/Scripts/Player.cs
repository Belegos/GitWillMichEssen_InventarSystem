using System;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float HP = 100;
    public float MP = 100;
    public float Speed = 10;
    [SerializeField] Inventory _inventory;
    [SerializeField] List<AItem> _collectList;

    private void Awake()
    {
        _inventory = GetComponent<Inventory>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AItem itemToAdd = _collectList[0];
            _collectList.RemoveAt(0);
            _inventory.AddItem(itemToAdd);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            _inventory.UseItem();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField]GameObject Telephone_Number;
    [SerializeField]GameObject Entrance_key;

    [SerializeField]GameObject get_Telephone_Number;
    [SerializeField]GameObject get_Entrance_key;

    [SerializeField]GameObject Rack_Text;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ItemClick()
    {
        Telephone_Number.SetActive(true);
        Entrance_key.SetActive(true);
    }

    public void ItemClose()
    {
        Telephone_Number.SetActive(false);
        Entrance_key.SetActive(false);

        get_Telephone_Number.SetActive(true);
        get_Entrance_key.SetActive(true);
    }
}

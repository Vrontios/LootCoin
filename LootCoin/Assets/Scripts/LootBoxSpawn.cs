using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootBoxSpawn : MonoBehaviour
{
    public GameObject lootBox;

    private GameObject _instance;

    
    
    
    public void ClickThisButton()
    {
        _instance = Instantiate(lootBox, new Vector3(0, 0, 0), Quaternion.identity);
        LootBoxCounter.LootboxCount += 1;
    }
   public void Delete()
    {
        Destroy(_instance);
    }


    }

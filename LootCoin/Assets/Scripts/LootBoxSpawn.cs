using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootBoxSpawn : MonoBehaviour
{
    public GameObject lootBox;
    public List<GameObject> usedLootBox;
    private GameObject _instance;
    public Transform Spawn;

    
    
    
    public void ClickThisButton()
    {
        if (usedLootBox.Count != 0)
        {
            Destroy(usedLootBox[0]);
            usedLootBox.Remove(usedLootBox[0]);
            SpawnItem();
        }
        else SpawnItem();
    }

    private void SpawnItem()
    {
        GameObject clone = Instantiate(lootBox, Spawn.position, Spawn.rotation) as GameObject;
        usedLootBox.Add(clone); // adds instantiated box to list
        LootBoxCounter.LootboxCount += 1;
       // Animator anim = clone.GetComponent<Animator>();
        //anim.Play("LootboxopenAnim");
       
    }
}
    

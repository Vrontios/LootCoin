using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootBoxCounter : MonoBehaviour
{
    public static int LootboxCount;
    public GameObject LootboxDisplay;
    public int InternalLootbox;
    void Update()
    {
        InternalLootbox = LootboxCount;
        LootboxDisplay.GetComponent<Text>().text = "" + InternalLootbox;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBoxOpen : MonoBehaviour
{
    public void ClickButton()
    {
        if (LootBoxCounter.LootboxCount > 0) { 
        LootBoxCounter.LootboxCount -= 1;
    }
    }
}

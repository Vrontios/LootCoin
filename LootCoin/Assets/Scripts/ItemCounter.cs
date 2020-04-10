using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCounter : MonoBehaviour
{
    public static int ItemCount;
    public GameObject ItemDisplay;
    public int InternalItem;

    // Update is called once per frame
    void Update()
    {
        InternalItem = ItemCount;
        ItemDisplay.GetComponent<Text>().text = "" + InternalItem;
    }
}

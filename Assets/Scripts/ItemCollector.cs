using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    private int strawberry = 0;
    [SerializeField] private TMP_Text Result;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("StrawBerry"))
        {
            Destroy(collision.gameObject);
            strawberry++;
            Result.text= "StrawBerry: " + strawberry;
        }
    }
}

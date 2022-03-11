using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemCollector : MonoBehaviour
{
    // Start is called before the first frame update

    private int collected = 0;
    
    [SerializeField] private Text collectedText;
    
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("Orange")) 
        {
            Destroy(collision.gameObject);
            collected++;
            collectedText.text = "Collected: " + collected;
            //Debug.Log("Collected " + collected);
        }
    }
}

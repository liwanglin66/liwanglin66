using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class key_collision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            FindObjectOfType<Soundmanger>().Play("Coin");
            key_score.keyAmount += 1;
            Destroy(gameObject);
        }
    }
}

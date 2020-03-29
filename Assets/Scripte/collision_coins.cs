using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_coins : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            FindObjectOfType<Soundmanger>().Play("Coin");
            ScoreTextScripte.coinAmount += 1;
            Destroy(gameObject);
        }
    }
}

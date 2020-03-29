using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WIn_tele : MonoBehaviour
{
    public GameObject win;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            
            win.SetActive(true);
        }
    }
}

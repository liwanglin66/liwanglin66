using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    public float speed;
    private Transform target;
    public static float healthAomunt;
    public GameObject gameover;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemymove.healthAomunt = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
      
    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag.Equals("Player"))
        {
            
            Debug.Log("hit");
            Destroy(col.gameObject);
            gameover.SetActive(true);
        }
    }
}

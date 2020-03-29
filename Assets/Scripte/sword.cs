using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class sword : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        FindObjectOfType<Soundmanger>().Play("sword");
        Debug.Log(enemymove.healthAomunt);

        if (col.gameObject.tag.Equals("enemy")) {
           
            Destroy(col.gameObject);}
    }
    void OnCollisionStay(Collision collide)
    {
        //Output the name of the GameObject you collide with
        Debug.Log("I hit the GameObject : " + collide.gameObject.name);
    }
}

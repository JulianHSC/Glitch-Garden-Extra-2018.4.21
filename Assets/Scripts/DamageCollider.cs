using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        Destroy(otherCollider.gameObject);
        FindObjectOfType<LivesDisplay>().TakeLife();
    }

    /*
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlareBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Nothing has been set up for you in regards to rigidbody and colliders on Bullet and Target. 
    //Collisions are notorious for being confusing as to which object needs the collider and when it triggers
    //Please refer to the chart in the homework document to help you

    //Overall what you need to be doing is finding a way to detect when something has collided with the Bullet
    //This will require the use of "OnCollisionEnter" and will need require a specific
    //Combination of rigidbodies, isKinematic settings, and colliders
    //OnCollisionEnter should be used on the bullet. It can techincally be done on the target
    //But this is bad practice b/c you'd need it on all targetable objects

    //Your goal is to Debug.Log("I've hit the target!") when hitting only the target. 
    //For determining what you've hit, use the Tag property of Collision.GameObject.Tag to
    //check the tag of the gameobjecy you've hit (meaning you must put a tag on the target!)
    



}

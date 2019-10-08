﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlareGunFiring : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource firingSound;

    public GameObject flareBullet; 
    void Start()
    {
        firingSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Checks every frame to see if you pressed fire (left click) while flare gun is enabled
        if (Input.GetButtonDown("FireGun")){
            fireFlareGun();
            Debug.Log("firing flare gun");
        }
    }

    // Fire the Gun using forces instead of raycasting. 
    // The main idea is as follows: 
    // Spawn Bullet in front of gun 
    // Make sure Bullet's orientation is correct using Transform Rotations
    // Add force in the direction in which you want the gun to 'fire' 
    // Make sure bullet is set up with colliders correctly to detect impact! 
    // (This requires some work in the bullet prefab script!)
    // After you've done all your work, call fireFlareGunSounds() for fancy sounds!

    //In your on collisionenter script, call the onHit from the target if a hit is detected.
    void fireFlareGun(){
        fireFlareGunSounds(); 
    }

    void fireFlareGunSounds(){
        firingSound.Play();
    }

}

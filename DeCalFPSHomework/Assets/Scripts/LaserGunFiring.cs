using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGunFiring : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject FPSCam;
    public GameObject targetObject;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Checks every frame to see if you pressed fire (left click) while laser gun is enabled
        if (Input.GetButtonDown("FireGun")){
            fireLaserGun();
            Debug.Log("firing laser gun");
        }
    }

    //This firing function is going to use raycasting because its a laser and isn't subject to physics! 
    // The overall idea is fire a raycast (it's kind of already like a laser) from the FPSCam
    // And use the data of where it hits as a bullet
    // Raycasts collide with all colliders unless given a LayerMask to filter out
    // You can either filter out all layerMasks besides the target, or you can use gameobject tags to detect the target
    // LayerMasks are basically just integers that tell you what type of things you've hit
    // These integers can be set to whatever you want exactly like tags
    // The best way to think about it is as generalizable tags with integers instead of strings


    //The raycast function requires inputs that you should take from the camera, such as the position and direction
    //Call our custom fireLaserVisuals() function after you raycast to get cool visuals!

    // If you hit, call the custom onHit() function we created to update the scoreboard
    // attached to the target. This requires getting the script component attached to the target
    // and calling the public void in that class. Use the GetComponent method for this. 
    // We've already given access to the target gameobject above
    void fireLaserGun(){
        //Implement all raycast stuff!!
        fireLaserVisuals();
        
    }


    void fireLaserVisuals(){
        //TODO: Ben -> We need something that fires a laser in the direction of the camera and makes cool noises
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public GameObject flareGun;
    public GameObject laserGun;

    int gunCase; 


    // Start is called before the first frame update
    void Start()
    {
        flareGun.SetActive(false);
        laserGun.SetActive(true);
        gunCase = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("SwapGuns")){
            swapGuns();
            Debug.Log("Swapping Guns");
        }
    }

    public void swapGuns(){
        switch(gunCase){
            case 1:
                flareGun.SetActive(true);
                laserGun.SetActive(false);
                gunCase = 2;
                break;
            case 2:
                flareGun.SetActive(false);
                laserGun.SetActive(true);
                gunCase = 1;
                break;

        }
        return;
    }

}

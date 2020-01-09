using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    public GameObject health10;
    public GameObject health15;
    public GameObject health20;
    public GameObject health30;
    public GameObject health50;

    private int DropNumber;
    
    public void Spawn()
    {

        DropNumber = Random.Range(1,101);

        if (DropNumber <= 20)
        {

            GameObject tempItemSpawn = Instantiate(health10, transform.position, transform.rotation) as GameObject;

            tempItemSpawn.transform.position = this.transform.position;

            //Turn on the temp spawn incase it spawns as deactivated;

            tempItemSpawn.SetActive(true);
        }

        else if(DropNumber > 20 && DropNumber < 29)
        {
            GameObject tempItemSpawn = Instantiate(health15, transform.position, transform.rotation) as GameObject;

            tempItemSpawn.transform.position = this.transform.position;

            //Turn on the temp spawn incase it spawns as deactivated;

            tempItemSpawn.SetActive(true);
        } else if (DropNumber > 29 && DropNumber < 36)
        {
            GameObject tempItemSpawn = Instantiate(health20, transform.position, transform.rotation) as GameObject;

            tempItemSpawn.transform.position = this.transform.position;

            //Turn on the temp spawn incase it spawns as deactivated;

            tempItemSpawn.SetActive(true);
        } else if (DropNumber > 36 && DropNumber < 41)
        {
            GameObject tempItemSpawn = Instantiate(health30, transform.position, transform.rotation) as GameObject;

            tempItemSpawn.transform.position = this.transform.position;

            //Turn on the temp spawn incase it spawns as deactivated;

            tempItemSpawn.SetActive(true);
        } else if(DropNumber > 41 && DropNumber <44)
        {
            GameObject tempItemSpawn = Instantiate(health50, transform.position, transform.rotation) as GameObject;

            tempItemSpawn.transform.position = this.transform.position;

            //Turn on the temp spawn incase it spawns as deactivated;

            tempItemSpawn.SetActive(true);
           
        }
    }
}
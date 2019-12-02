using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowWeapon : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform arrowSpawn;
    public float fireTime = 0.9f;
    public float drawBack = 0;
    public float drawBackLimit = 10;
    public float drawBackSpeed = 5;

    private bool isFiring = false;


    private void SetFiring()
    {
        isFiring = false;
    }

    private void Fire()
    {
        isFiring = true;
        GameObject arrow = Instantiate(arrowPrefab, arrowSpawn.position, arrowSpawn.rotation);

        int damage = arrow.GetComponent<Bullet>().damage;

        damage += (int)drawBack;

        arrow.GetComponent<Bullet>().damage = damage;

        Invoke("SetFiring", fireTime);
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (drawBack < drawBackLimit)
            {
                drawBack += Time.deltaTime * drawBackSpeed;
            }
            
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (!isFiring)
            {
                Fire();
            }
            drawBack = 0;
        }
    }
}

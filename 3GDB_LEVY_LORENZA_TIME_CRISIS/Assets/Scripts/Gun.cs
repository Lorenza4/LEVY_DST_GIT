using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
   public GameObject projectile;
   public float launchVelocity = 700f;
 
   void Update()
   {
        if (Input.GetMouseButtonDown(0))
       {
           GameObject ball = Instantiate(projectile, transform.position, transform.rotation);
           ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchVelocity,0));
       }
   }
}


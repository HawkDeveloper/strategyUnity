using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAttack : MonoBehaviour
{
   public float radius = 70f;

   private void Update() 
   {
        DetectCollistion();
   }     
    

    private void DetectCollistion()
    {
       Collider[] hitCollider = Physics.OverlapSphere(transform.position, radius);
       foreach (var el in hitCollider)
       {
            if((gameObject.CompareTag("Player") && el.gameObject.CompareTag("Enemy")) ||
               (gameObject.CompareTag("Enemy") && el.gameObject.CompareTag("Player")))
               {
                if (gameObject.CompareTag("Enemy"))
                    GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(el.transform.position);
               }
       }
    }
}

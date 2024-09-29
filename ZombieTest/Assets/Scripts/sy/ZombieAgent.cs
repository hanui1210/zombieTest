using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAgent : MonoBehaviour
{
    public LayerMask whatisTarget;
    private NavMeshAgent meshAgent; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
               // Collider  = Physics.OverlapSphere(this.transform.position, 3, this.whatisTarget);
              //  Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
              // Debug.DrawRay(ray.origin, ray.direction * 100f, Color.yellow, 100);
              // RaycastHit hit;
              // if(Physics)
            }
        }
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, 3);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public ZombieController zombieController;
    public ZombieController zonmbiePrefab;
    public float health = 1f;
    // Start is called before the first frame update
    void Start()
    {
        zombieController = GetComponent<ZombieController>();
    }

    // Update is called once per frame
    void Update()
    {
      //  zombieController.onDeath += () => 
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventMain : MonoBehaviour
{
   UnityEvent myEvent;
    // Start is called before the first frame update
    void Start()
    {
        this.myEvent = new UnityEvent();
        this.myEvent.AddListener(()=>
        {
            Debug.Log("�̺�Ʈ�߻�");
        });
        this.myEvent.Invoke();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

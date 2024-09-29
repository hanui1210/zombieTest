using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SrepMain : MonoBehaviour
{
    public Woman woman;
    public Transform sp;
    public Transform ep;
    [Range(0f,1f)]
    public float t = 0f;
    public float duration = 5.0f; // 이동시간
    private float elapsedTime = 0f; // 누적시간
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.elapsedTime += Time.deltaTime;
            t = this.elapsedTime / duration;
            // this.woman.transform.position = Vector3.Lerp(this.sp.position, this.ep.position, t);
            if(t >= 1.0f)
            {
            this.woman.transform.rotation = Quaternion.Euler(new Vector3(0,90,0));
                Debug.Log("move");
            }
            
        }
    }
}

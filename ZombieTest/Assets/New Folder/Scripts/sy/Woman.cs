using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomanTset : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    private Animator animator;
    private Rigidbody rb;
  
    // 캐릭터 이동
    // 쿼터니엄 
    void Start()
    {
        //  this.transform.rotation = Quaternion.AngleAxis(45,Vector3.up);    
        this.animator = GetComponent<Animator>();
        
        this.rb = GetComponent<Rigidbody>();

    }
    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        var dir = new Vector3(h, 0, v).normalized;
        DrawArrow.ForDebug(this.transform.position, dir, 0, Color.red, ArrowType.Solid);
        if (dir != Vector3.zero)
        {
            var angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
            this.transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
        }
        // 상대적으로 이동할 거리 계산
        Vector3 moveDistance = dir * moveSpeed * Time.deltaTime;

        // 리지드바디를 통해 게임 오브젝트 위치 변경
        this.rb.MovePosition(this.rb.position + moveDistance);

    }
    
   
}

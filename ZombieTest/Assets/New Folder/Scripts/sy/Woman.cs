using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomanTset : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    private Animator animator;
    private Rigidbody rb;
  
    // ĳ���� �̵�
    // ���ʹϾ� 
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
        // ��������� �̵��� �Ÿ� ���
        Vector3 moveDistance = dir * moveSpeed * Time.deltaTime;

        // ������ٵ� ���� ���� ������Ʈ ��ġ ����
        this.rb.MovePosition(this.rb.position + moveDistance);

    }
    
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class LerpMain : MonoBehaviour
{
    public Woman woman;
    public Transform startPoint;
    public Transform endPoint;
    //[Range(0f,1f)]
    //public float t = 0;
    //public float duration = 2.0f; // �̵��ð�
    //private float elapsedTime = 0f; // �����ð�
    //private bool ismoveCompletel = false;

    private void Start()
    {
        //this.woman.transform.DOMove(endPoint.position, 2f).OnComplete(()=> {
        //    Debug.Log("move complete");
        //});
        
        //
        // ���ϴ°����� �̵� 
        //this.woman.transform.DOMove(endPoint.position, 2f).SetEase(Ease.OutQuad).
        //    OnComplete(() =>
        //{
        //    Debug.Log("move complete");
        //});

        // ���ϴ°����� ȸ��
        this.woman.transform.DORotate(new Vector3(0, 90, 0), 2f).SetEase(Ease.InOutQuad).
            OnComplete(() =>
            {
                Debug.Log("move complete");
            });


    }
    void Update()
    {
       //// woman.transform.position = Vector3.Lerp(startPoint.position, endPoint.position, t);   
       // this.elapsedTime += Time.deltaTime;

       // float t = this.elapsedTime / duration;

       // this.woman.transform.position 
       //     = Vector3.Lerp(this.startPoint.position, this.endPoint.position, t);
       // Debug.Log(t);

       // if(t >= 1.0f)
       // {
       //     ismoveCompletel = true;
       //     Debug.Log("move completel");
       // }




    }
}

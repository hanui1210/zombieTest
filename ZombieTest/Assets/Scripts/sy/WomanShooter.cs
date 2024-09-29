using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomanShooter : MonoBehaviour
{
   [SerializeField] public GunController gunController; // 사용할 총
    [SerializeField]public Transform GunPivot; // 총 배치의 기준점
    [SerializeField] public Transform leftHandMounts; // 총의 왼쪽 손잡이, 왼손이 위치할 지점
    [SerializeField] public Transform rightHandMounts; // 총의 오른쪽 손잡이, 오른손이 위치할 지점

    private Woman woman;
    private Animator animator; // 애니메이터 컴포넌트

    private void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        // 슈터가 활성화될 때 총도 함께 활성화
        this.gunController.gameObject.SetActive(true);
    }

    private void OnDisable()
    {
        // 슈터가 비활성화될 때 총도 함께 비활성화
        this.gunController.gameObject.SetActive(false);
    }

    private void Update()
    {
        // 입력을 감지하고 총 발사하거나 재장전
        if (Input.GetMouseButtonDown((0)))   
        {
            this.gunController.Fire();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            if (this.gunController.Reload())
            {
                animator.SetTrigger("Reload");
            }
        }

    }


    [Range(0f, 1f)]
    [SerializeField]
    private float LeftHandWeights = 0f;
    [Range(0f, 1f)]
    [SerializeField]
    private float RightHandWeights = 0f;

    // 애니메이터의 IK 갱신
    private void OnAnimatorIK(int layerIndex)
    {
        this.GunPivot.position = this.animator.GetIKHintPosition(AvatarIKHint.RightElbow);
        this.animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1.0f);
        this.animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1.0f);

        this.animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHandMounts.position);
        this.animator.SetIKRotation(AvatarIKGoal.LeftHand, leftHandMounts.rotation);

        this.animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1.0f);
        this.animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1.0f);

        this.animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandMounts.position);
        this.animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandMounts.rotation);
    }
}

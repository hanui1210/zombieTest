using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomanShooter : MonoBehaviour
{
   [SerializeField] public GunController gunController; // ����� ��
    [SerializeField]public Transform GunPivot; // �� ��ġ�� ������
    [SerializeField] public Transform leftHandMounts; // ���� ���� ������, �޼��� ��ġ�� ����
    [SerializeField] public Transform rightHandMounts; // ���� ������ ������, �������� ��ġ�� ����

    private Woman woman;
    private Animator animator; // �ִϸ����� ������Ʈ

    private void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        // ���Ͱ� Ȱ��ȭ�� �� �ѵ� �Բ� Ȱ��ȭ
        this.gunController.gameObject.SetActive(true);
    }

    private void OnDisable()
    {
        // ���Ͱ� ��Ȱ��ȭ�� �� �ѵ� �Բ� ��Ȱ��ȭ
        this.gunController.gameObject.SetActive(false);
    }

    private void Update()
    {
        // �Է��� �����ϰ� �� �߻��ϰų� ������
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

    // �ִϸ������� IK ����
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

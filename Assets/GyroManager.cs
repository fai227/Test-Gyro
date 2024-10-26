using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroManager : MonoBehaviour
{
    public float smoothSpeed = 5f; // ��Ԃ̃X�s�[�h�𒲐�����p�����[�^

    private void Start()
    {
        // �W���C���Z���T�[�̎g�p��L���ɂ���
        Input.gyro.enabled = true;
    }

    private void Update()
    {
        // �W���C���̉�]�����擾
        Quaternion gyroRotation = Input.gyro.attitude;

        // Z���̉�]�����ɒ��ځi���[�p�j
        float zRotation = gyroRotation.eulerAngles.z;

        // ���݂̉�]���擾
        Quaternion currentRotation = transform.rotation;

        // �ڕW��Z����]�݂̂𔽉f������]
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, zRotation);

        // ���̂܂�targetRotation�𔽉f������������

        // ���݂̉�]�ƖڕW�̉�]�̊Ԃ���
        transform.rotation = Quaternion.Lerp(currentRotation, targetRotation, Time.deltaTime * smoothSpeed);
    }
}

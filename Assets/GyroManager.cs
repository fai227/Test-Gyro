using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroManager : MonoBehaviour
{
    public float smoothSpeed = 5f; // 補間のスピードを調整するパラメータ

    private void Start()
    {
        // ジャイロセンサーの使用を有効にする
        Input.gyro.enabled = true;
    }

    private void Update()
    {
        // ジャイロの回転情報を取得
        Quaternion gyroRotation = Input.gyro.attitude;

        // Z軸の回転だけに注目（ヨー角）
        float zRotation = gyroRotation.eulerAngles.z;

        // 現在の回転を取得
        Quaternion currentRotation = transform.rotation;

        // 目標のZ軸回転のみを反映した回転
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, zRotation);

        // そのままtargetRotationを反映させる手もある

        // 現在の回転と目標の回転の間を補間
        transform.rotation = Quaternion.Lerp(currentRotation, targetRotation, Time.deltaTime * smoothSpeed);
    }
}

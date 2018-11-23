using System;
using UnityEngine;

/// <summary>
/// 选角场景配置参数
/// </summary>
[Serializable]
public class SelectCharacterInfo
{
    [Tooltip("角色旋转速度")]
    public float CharacterRotationSpeed = 0;

    [Tooltip("角色旋转速度速度最大值")]
    public float CharacterRotationMaxSpeed = 0;

    [Tooltip("摄像机最近坐标")]
    public float CameraNearestPostionZ = 0;

    [Tooltip("摄像机Z轴移动速度")]
    public float CameraZTranslateSpeed = 0;

    [Tooltip("摄像机Y轴移动速度")]
    public float CameraYTranslateSpeed = 0;

    [Tooltip("摄像机X轴旋转速度")]
    public float CameraXRotateSpeed = 0;

    [Tooltip("是否开启惯性")]
    public bool IsInertia = true;

    [Tooltip("惯性指数"), Range(0, 0.99f)]
    public float IndexOfInertia = 0;
}

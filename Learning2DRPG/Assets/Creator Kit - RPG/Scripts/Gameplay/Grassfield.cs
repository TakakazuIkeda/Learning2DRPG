using RPGM.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grassfield : MonoBehaviour
{
    /// <summary>
    /// 2D�̐N������ł�
    /// OnTriggerEnter2D�͐N�����ɍs������ł�
    /// </summary>
    /// <param name="characterCollider">�v���C���[�̃L�����N�^�[</param>
    void OnTriggerEnter2D(Collider2D characterCollider)
    {
        characterCollider.GetComponent<CharacterController2D>().speed *= 0.5f;
    }

    /// <summary>
    /// 2D�̐N������ł�
    /// OnTriggerExit2D�͐N�����Ă��甲���Ă���̔���ł�
    /// </summary>
    /// <param name="characterCollider">�v���C���[�̃L�����N�^�[</param>
    void OnTriggerExit2D(Collider2D characterCollider)
    {
        characterCollider.GetComponent<CharacterController2D>().speed *= 2f;
    }

    public void Sum(int a, int b)
    {
        int SumValue = a * b;
        Debug.Log(SumValue);
    }

    void Start()
    {
        Sum(5800, 2);
    }
}




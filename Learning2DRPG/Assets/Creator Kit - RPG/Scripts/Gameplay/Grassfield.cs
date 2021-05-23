using RPGM.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grassfield : MonoBehaviour
{
    /// <summary>
    /// 2Dの侵入判定です
    /// OnTriggerEnter2Dは侵入時に行う判定です
    /// </summary>
    /// <param name="characterCollider">プレイヤーのキャラクター</param>
    void OnTriggerEnter2D(Collider2D characterCollider)
    {
        characterCollider.GetComponent<CharacterController2D>().speed *= 0.5f;
    }

    /// <summary>
    /// 2Dの侵入判定です
    /// OnTriggerExit2Dは侵入してから抜けてからの判定です
    /// </summary>
    /// <param name="characterCollider">プレイヤーのキャラクター</param>
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




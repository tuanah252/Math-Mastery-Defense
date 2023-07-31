using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyed : MonoBehaviour
{
    public GameObject prefab;
    public Transform[] targets; // Mảng các vị trí mục tiêu

    void OnDestroy()
    {
        Spawn();
    }

    void Spawn()
    {
        Transform randomTarget = targets[Random.Range(0, targets.Length)];
        GameObject obj = Instantiate(prefab, randomTarget.position, Quaternion.identity);
        obj.SetActive(true);
    }
}

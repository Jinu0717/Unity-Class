using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public GameObject target;
    private float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards
            (
                transform.position,         // 현재 자기 자신의 위치
                target.transform.position,  // 목표물 게임 오브젝트의 위치
                speed * Time.deltaTime      // 현재 위치에서 목표 위치로 이동할 속도
            );
    }
}

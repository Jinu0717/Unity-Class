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
                transform.position,         // ���� �ڱ� �ڽ��� ��ġ
                target.transform.position,  // ��ǥ�� ���� ������Ʈ�� ��ġ
                speed * Time.deltaTime      // ���� ��ġ���� ��ǥ ��ġ�� �̵��� �ӵ�
            );
    }
}

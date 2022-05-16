using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public GameObject target;
    private float speed = 1.0f;

    private MeshRenderer render;

    private void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Transform 컴포넌트에 접근해서 위치를 가져옵니다.
        transform.position = Vector3.MoveTowards
        (
            transform.position,         // 현재 자기 자신의 위치
            target.transform.position,  // 목표물 게임 오브젝트의 위치
            speed * Time.deltaTime      // 현재 위치에서 목표 위치로 이동할 속도
        );

        // 키를 눌렀을 때 동작합니다.
        // KeyCode.Return = Enter
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // 쿨타임 때 사용 가능
            Invoke("Paint", 3);
        }
    }

    public void Paint()
    {
        // Random.Range(?, ?) ?와 ? - 1 사이의 난수값을 반환하는 클래스입니다.
        int value = Random.Range(0, 3);

        switch (value)
        {
            case 0:
                // render라는 변수의 머티리얼 색상을 초록색으로 설정합니다.
                render.material.color = Color.green;
                break;
            case 1:
                // render라는 변수의 머티리얼 색상을 빨간색으로 설정합니다.
                render.material.color = Color.red;
                break;
            case 2:
                // render라는 변수의 머티리얼 색상을 검은색으로 설정합니다.
                render.material.color = Color.black;
                break;
        }
    }
}

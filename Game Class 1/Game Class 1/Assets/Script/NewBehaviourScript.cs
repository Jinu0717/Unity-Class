using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 최대공약수
    int x = 60;
    int y = 48;

    int result;

    // Awake 함수는 Start 함수 이전에 한 번만 호출되는 함수입니다.
    private void Awake()
    {
        Debug.Log("Awake 함수입니다.");
    }

    // Start 함수는 게임 시작할 때 한 번만 호출되는 함수입니다.
    void Start()
    {
        // 호출할 함수의 이름과 몇 초 후에 함수를 실행할 지 설정하고 몇 초마다 반복할 것인지 정한다.
        InvokeRepeating("AutoMove", 0, 1);

        /*
        // 자기 자신의 위치를 설정합니다.
        transform.position += new Vector3
        (
            transform.position.x,
            transform.position.y,
            transform.position.z + 1
         );
        */

        Debug.Log("Start 함수입니다.");

        for (int i = 1; i <= x && i <= y; i++)
        {
            if (x % i == 0 && y % i == 0)
            {
                result = i;
            }
        }

        Debug.Log(result);
    }

    void Update()
    { 
        if(Input.GetKey(KeyCode.A))
        {
            // Vector3.left = (-1, 0, 0);

            // left + 프레임 속도 * 0.016(60 프레임)
            // left + 프레임 속도 * 0.03(30 프레임)
            transform.position += Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            // Vector3.left = (1, 0, 0);

            // right + 프레임 속도 * 0.016(60 프레임)
            // right + 프레임 속도 * 0.03(30 프레임)
            transform.position += Vector3.right * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            // Vector3.left = (0, 0, 1);

            // forward + 프레임 속도 * 0.016(60 프레임)
            // forward + 프레임 속도 * 0.03(30 프레임)
            transform.position += Vector3.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            // Vector3.left = (0, 0, -1);

            // back + 프레임 속도 * 0.016(60 프레임)
            // back + 프레임 속도 * 0.03(30 프레임)
            transform.position += Vector3.back * Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            CancelInvoke("AutoMove");
        }
    }

    public void AutoMove()
    {
        transform.position = new Vector3
        (
            Random.Range(0, 5),
            0,
            Random.Range(0, 5)
        );
    }
}

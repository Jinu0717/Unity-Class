using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // �ִ�����
    int x = 60;
    int y = 48;

    int result;

    // Awake �Լ��� Start �Լ� ������ �� ���� ȣ��Ǵ� �Լ��Դϴ�.
    private void Awake()
    {
        Debug.Log("Awake �Լ��Դϴ�.");
    }

    // Start �Լ��� ���� ������ �� �� ���� ȣ��Ǵ� �Լ��Դϴ�.
    void Start()
    {
        // ȣ���� �Լ��� �̸��� �� �� �Ŀ� �Լ��� ������ �� �����ϰ� �� �ʸ��� �ݺ��� ������ ���Ѵ�.
        InvokeRepeating("AutoMove", 0, 1);

        /*
        // �ڱ� �ڽ��� ��ġ�� �����մϴ�.
        transform.position += new Vector3
        (
            transform.position.x,
            transform.position.y,
            transform.position.z + 1
         );
        */

        Debug.Log("Start �Լ��Դϴ�.");

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

            // left + ������ �ӵ� * 0.016(60 ������)
            // left + ������ �ӵ� * 0.03(30 ������)
            transform.position += Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            // Vector3.left = (1, 0, 0);

            // right + ������ �ӵ� * 0.016(60 ������)
            // right + ������ �ӵ� * 0.03(30 ������)
            transform.position += Vector3.right * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            // Vector3.left = (0, 0, 1);

            // forward + ������ �ӵ� * 0.016(60 ������)
            // forward + ������ �ӵ� * 0.03(30 ������)
            transform.position += Vector3.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            // Vector3.left = (0, 0, -1);

            // back + ������ �ӵ� * 0.016(60 ������)
            // back + ������ �ӵ� * 0.03(30 ������)
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

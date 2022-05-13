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

        for(int i = 1; i <= x && i <= y; i++)
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
            Debug.Log("Update �Լ��Դϴ�.");
        }
    }
}

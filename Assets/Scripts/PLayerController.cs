using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour
{
    [SerializeField] float forwardSpeed = 1;
    [SerializeField] float sideSpeeds = 1;

    Rigidbody playerRigidbody;

    private void Awake()
    {
       playerRigidbody = GetComponent<Rigidbody>();
    }
    //����� ������ ��� ������, ������� ����� ����������� � ������ ������� ������ 

    void Update()
    {
    }

    //��� �� Update, �� ����������� ����� ������������� ���-�� ������� 
    //������ �������� ��� ��������
    //�������� � ������� ����� 

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //deltaTime - ������� ���������� �������, fixedDeltaTime - ���������� ��������

        playerRigidbody.AddForce(new Vector3(horizontal * Time.fixedDeltaTime * forwardSpeed, 0, vertical * Time.fixedDeltaTime * sideSpeeds));

        //transform.position += new Vector3(horizontal * Time.deltaTime, 0, vertical * Time.deltaTime);

    }
}

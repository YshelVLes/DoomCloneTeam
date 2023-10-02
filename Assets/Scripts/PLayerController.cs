using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour
{
    [SerializeField] float forwardSpeed = 1;
    [SerializeField] float sideSpeeds = 1;
    [SerializeField] float mousespeed = 1;

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

        Vector3 force = Vector3.zero;
        force += transform.forward* vertical  *Time.fixedDeltaTime * forwardSpeed;
        force += transform.right * horizontal * Time.fixedDeltaTime * sideSpeeds;

        playerRigidbody.AddForce(force);

        float xMouseMovement = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0, xMouseMovement, 0));

        //transform.position += new Vector3(horizontal * Time.deltaTime, 0, vertical * Time.deltaTime);



    }
}

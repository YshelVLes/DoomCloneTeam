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
    //ћенее точный дл€ физики, котора€ будет обновл€тьс€ в другой частоте кадров 

    void Update()
    {
    }

    //тот же Update, но обновл€етс€ через фиксированное кол-во времени 
    //’орошо подходит дл€ консолей
    //работаем с физикой здесь 

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //deltaTime - частота обновлени€ объекта, fixedDeltaTime - посто€нна€ величина

        playerRigidbody.AddForce(new Vector3(horizontal * Time.fixedDeltaTime * forwardSpeed, 0, vertical * Time.fixedDeltaTime * sideSpeeds));

        //transform.position += new Vector3(horizontal * Time.deltaTime, 0, vertical * Time.deltaTime);

    }
}

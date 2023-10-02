using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medkit : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            FindObjectOfType<Character>().healthChange(10);
            Debug.Log("Health");

        }
        Destroy(gameObject);
    }
}

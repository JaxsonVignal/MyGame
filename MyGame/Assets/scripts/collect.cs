using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))] 
public class collect : MonoBehaviour
{
    public static event Action onCollected;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            onCollected?.Invoke();
            Destroy(gameObject);
        }
    }

}

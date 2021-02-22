using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePickup : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="Player")
        {
            GameManager.instance.IncreaseTime();
            Destroy(this.gameObject);
            
        }
    }
}

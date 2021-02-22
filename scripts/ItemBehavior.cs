using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    //1 
    private void OnCollisionEnter(Collision collision)
    {
        //2
        if (collision.gameObject.name == "Player")
        {
            //3 
            Destroy(this.gameObject);

            //4
            Debug.Log("Item Collected!");

            //5
            GameManager.instance.Decrement();


        }
    }
}

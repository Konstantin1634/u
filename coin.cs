using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other) {

        CoinsCounter coins = other.GetComponent<CoinsCounter>();

        coins.CollectCoins();

        Destroy(gameObject);

    }

}       

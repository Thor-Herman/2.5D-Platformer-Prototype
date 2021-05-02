using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Player player = collider.gameObject.GetComponent<Player>();
            player.AddCoin();
            Destroy(this.gameObject);
        }
    }

}

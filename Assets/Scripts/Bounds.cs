using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    [SerializeField]
    private Transform _respawnPoint;
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Player player = collider.gameObject.GetComponent<Player>();
            if (player != null)
                player.Damage(1);
            CharacterController cc = collider.gameObject.GetComponent<CharacterController>();
            if (cc != null)
            {
                cc.enabled = false; // Character controller falls too quickly to be respawned
                collider.transform.position = _respawnPoint.position;
                cc.enabled = true;
            }
        }
    }
}

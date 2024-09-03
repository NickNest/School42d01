using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportIN : MonoBehaviour
{
    [SerializeField] private Transform _positionOfTeleportOut;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.position = _positionOfTeleportOut.position;
    }
}

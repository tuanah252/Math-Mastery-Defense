using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    // Vị trí mới khi teleport
    public Transform teleportPosition;

    private void Start()
    {
        
    }

    private void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("zombie"))
        {
            // Thực hiện teleport đối tượng hiện tại (mũi tên) tới vị trí mới
            TeleportToPosition(teleportPosition.position);
        }
    }

    private void TeleportToPosition(Vector3 position)
    {
        // Di chuyển đối tượng hiện tại tới vị trí mới
        transform.position = position;
    }
}

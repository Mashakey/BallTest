using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Transform _playerPosition;

    private float offsetZ = 15f;
    private float smoothing = 2f;
    
    private void Start()
    {
        _playerPosition = FindObjectOfType<BallMovement>().transform;
    }

    private void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        Vector3 targwtPosition = new Vector3(_playerPosition.position.x, transform.position.y, _playerPosition.position.z - offsetZ);
        transform.position = Vector3.Lerp(transform.position, targwtPosition, smoothing * Time.deltaTime);
    }
}

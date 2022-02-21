using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    public float _moveSpeed = 10f;

    private float _lastMouseX;

    private void Start()
    {
        _lastMouseX = Input.mousePosition.x;
    }
    void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);

        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x > _lastMouseX)
            {
                transform.Translate(Vector3.right * _moveSpeed * Time.deltaTime);
            }
            else if (Input.mousePosition.x < _lastMouseX)
            {
                transform.Translate(-Vector3.right * _moveSpeed * Time.deltaTime);
            }
        }
    }

    public void ResetSpeed()
    {
        _moveSpeed = 10f;
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _moveDistance = 1;
    private float _moveDelay = 0;
    
    void Update()
    {
        if (_moveDelay < 0) { 
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y + _moveDistance, 0), transform.rotation);
            _moveDelay = 0.25f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y - _moveDistance, 0), transform.rotation);
            _moveDelay = 0.25f;
            }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.SetPositionAndRotation(new Vector3(transform.position.x + _moveDistance, transform.position.y, 0), transform.rotation);
            _moveDelay = 0.25f;
            }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.SetPositionAndRotation(new Vector3(transform.position.x - _moveDistance, transform.position.y, 0), transform.rotation);
            _moveDelay = 0.25f;
            }
    }
        _moveDelay -= Time.deltaTime;
    }

}

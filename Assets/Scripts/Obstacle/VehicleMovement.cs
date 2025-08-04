using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VehicleMovement : MonoBehaviour
{
    [SerializeField] float Speed;

    void Update()
    {
        this.gameObject.transform.position += (new Vector3(Speed, 0, 0) * Time.deltaTime);
        if (transform.position.x > 15)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}

using System;
using UnityEngine;

public class Move : MonoBehaviour
{ 
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;
    public void OnMove(Vector3 dir)
    {
        direction = dir;

        direction.Normalize();

        transform.position += dir * speed * Time.deltaTime;
    }
}

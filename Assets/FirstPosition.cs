using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPosition : MonoBehaviour
{
    [SerializeField] Transform paddle;
    Vector3 offset;

    private void Start()
    {
        offset = transform.position - paddle.position;
    }

    private void Update()
    {
        transform.position = paddle.position + offset;
    }
}

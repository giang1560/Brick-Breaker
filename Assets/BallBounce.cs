using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public float bounceForce = 10f; // Lực đẩy khi bóng nảy
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Giới hạn vị trí di chuyển của bóng trong khoảng giới hạn của màn hình
        float minX = -7.27f;
        float maxX = 7.27f;
        float minY = -5f;
        float maxY = 5f;

        Vector3 currentPosition = transform.position;
        currentPosition.x = Mathf.Clamp(currentPosition.x, minX, maxX);
        currentPosition.y = Mathf.Clamp(currentPosition.y, minY, maxY);
        transform.position = currentPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            Vector3 paddleCenter = collision.transform.position;
            Vector3 ballPosition = transform.position;

            Vector2 bounceDirection = ballPosition - paddleCenter; // Sử dụng Subtract để tính toán hướng nảy

            rb.velocity = Vector2.zero; // Đặt vận tốc của bóng về 0
            rb.AddForce(bounceDirection.normalized * bounceForce, ForceMode2D.Impulse); // Áp dụng lực đẩy theo hướng nảy
        }
    }
}
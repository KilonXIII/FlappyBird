using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollPosition : MonoBehaviour
{
    public float speed = -1f; // 1�ʿ� ��ĭ �������� �̵�.

    public float minX = -2;

    float width;
    private void Start()
    {
        width = GetComponentInChildren<BoxCollider2D>().size.x;
    }
    void Update()
    {
        // ���� ��ġ���� �ڷ� ���ٸ� ������ �̵���Ű��
        if (transform.position.x < minX)
        {
            transform.Translate(width * 2, 0, 0);
        }

        // ��ũ�� ���� �̵�.
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}

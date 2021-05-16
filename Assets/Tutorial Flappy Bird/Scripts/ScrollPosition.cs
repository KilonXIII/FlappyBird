using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollPosition : MonoBehaviour
{
    public float speed = -1f; // 1�ʿ� ��ĭ �������� �̵�.

    public float minX = -2;
    public Transform otherGround;
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        // ��ũ�� ó�� ��ġ�� �ű��
        if (transform.position.x < minX)
        {
            var pos = transform.position;
            pos.x = otherGround.position.x + 2;
            transform.position = pos;
        }
    }

    // Update���Ŀ� ȣ�� Late(����)
    private void LateUpdate()
    {
        // ��ġ�̵� x:speed, y:0, z:0
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}

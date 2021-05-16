using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    public float minX = -2;

    float width;
    private void Start()
    {
        width = GetComponentInChildren<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        // ���� ��ġ���� �ڷ� ���ٸ� ������ �̵���Ű��
        if (transform.position.x < minX)
        {
            transform.Translate(width * 2, 0, 0);
        }
    }
}

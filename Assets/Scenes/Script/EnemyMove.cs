using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float mSpeed;
    public float mDistance;

    private Vector3 startPos;
    private bool movingRight;
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(movingRight)
        {
            transform.Translate(Vector3.right * mSpeed * Time.deltaTime);
            if(transform.position.x >= startPos.x + mDistance)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * mSpeed * Time.deltaTime);
            if(transform.position.x <= startPos.x - mDistance)
            {
                movingRight = true;
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnimationFallStars : MonoBehaviour {

    public int NapravlenieX = -1;
    public float NapravlenieY = -0.5f;
    public float speed = 0.1f;

    Vector3 defPos;

    Vector3 direction;

    void Start()
    {
        direction = new Vector3(NapravlenieX, NapravlenieY, 0);

        defPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed + Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EndMap")
        {
            transform.position = defPos;
            speed = Random.Range(0.001f, 0.01f);
            transform.position = new Vector3(Random.Range(0, 1), Random.Range(0, 1), 0);
        }
    }

}

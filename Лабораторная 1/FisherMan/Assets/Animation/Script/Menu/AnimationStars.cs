using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStars : MonoBehaviour {

    private SpriteRenderer star;
    public float moveSpeed = 0.1f;
    public float destroyStarTime = 5f;

    private void Start()
    {
        star = GetComponent<SpriteRenderer>();
        Destroy(gameObject, destroyStarTime);
    }

    private void Update()
    {
        star.color = new Color(star.color.r, star.color.g, star.color.b, Mathf.PingPong(Time.time / 2.5f, 1.0f));
        transform.position += transform.up * Time.deltaTime * moveSpeed;
    }
}

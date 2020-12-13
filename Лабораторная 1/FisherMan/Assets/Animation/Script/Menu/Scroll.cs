using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    public float speed = 0.1f, checkPos = 0f;
    private RectTransform rectTransform;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        if(rectTransform.offsetMin.y != checkPos)
        {
            rectTransform.offsetMin += new Vector2(rectTransform.offsetMin.x, speed);
            rectTransform.offsetMax += new Vector2(rectTransform.offsetMax.x, speed);
        }
    }
}

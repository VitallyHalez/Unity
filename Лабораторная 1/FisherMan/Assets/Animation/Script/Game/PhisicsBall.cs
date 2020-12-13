using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhisicsBall : MonoBehaviour {

    public float angle = 0;
    public float radius = 1f;
    public float speed = 1f;
    public bool isCircle = false;

    public Vector2 cachedCenter;
	// Update is called once per frame
	void Update () {
        if (isCircle)
        {
            angle += Time.deltaTime;
            var x = Mathf.Cos(angle + speed) * radius ;
            var y = Mathf.Cos(angle + speed) * radius ;
            transform.position = new Vector2(x*-0.5f, y) + cachedCenter - new Vector2(radius, 0);
        }
        else
        {
            angle = 0;
            cachedCenter = transform.position;
            var x = transform.position.x;
            var y = transform.position.y;
            x += 0.5f * Time.deltaTime;
            transform.position = new Vector2(x, y);

        }
    }
    private void OnMouseDown()
    {
        isCircle = !isCircle;
    }
}

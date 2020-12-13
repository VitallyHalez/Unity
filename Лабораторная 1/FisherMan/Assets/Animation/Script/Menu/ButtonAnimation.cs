using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour {

    Vector3 defaultScale;

    private void Start()
    {
        defaultScale = transform.localScale;
    }

    private void OnMouseDown()
    {
        transform.localScale = new Vector3 (35f, 35f, 1f);
    }

    private void OnMouseUp()
    {
        transform.localScale = defaultScale;    
    }
}

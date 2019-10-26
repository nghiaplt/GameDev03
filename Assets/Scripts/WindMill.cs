using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindMill : MonoBehaviour
{
    public float speed = 5f;
    public bool flip = false;
    private RectTransform rectTransform;
    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        float speedFlip = flip ? -speed : speed;
        rectTransform.Rotate(new Vector3(0, 0, speedFlip*Time.deltaTime));
    }
}

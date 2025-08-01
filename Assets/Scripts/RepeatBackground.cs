using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWith;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        repeatWith = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWith)
        {
            transform.position = startPos;
        }
    }
}

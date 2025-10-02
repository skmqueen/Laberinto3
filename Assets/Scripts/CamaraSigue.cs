using UnityEngine;

public class CamaraSigue : MonoBehaviour
{
    public Transform target;

    Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = target.position - transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position = target.position - offset;
    }
}

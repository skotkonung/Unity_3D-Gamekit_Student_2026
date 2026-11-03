using UnityEngine;

public class WS1 : MonoBehaviour
{
    private Rigidbody rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            YSpeed();
        }
    }

    void YSpeed()
    {
        rb.linearVelocity = new Vector3(0, 3f, 0);
    }
}

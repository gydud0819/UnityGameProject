using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] private Vector3 direction;
    [SerializeField] private float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();


    }

    private void FixedUpdate()
    {
        // 공식이 기억이 안나는디 
        //rb.position += direction * moveSpeed * Time.deltaTime;// 머가 더 잇엇던거 가틍데 
        rb.AddForce(direction * moveSpeed, ForceMode.Force);
      
    }
}

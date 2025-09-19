using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] private Vector3 direction;
    [SerializeField] ForceMode forceMode;

    [SerializeField] float power;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        forceMode = ForceMode.Force;
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
        rb.AddForce(direction * power, forceMode);
       
    }

    public void Soar()
    {
        power = 0.5f;
        direction = Vector3.up;
        forceMode = ForceMode.Impulse;
    }

    public void Revert()
    {
        power = 5f;
        direction = Vector3.up;
        forceMode = ForceMode.Force;
    }
}

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
        // ������ ����� �ȳ��µ� 
        //rb.position += direction * moveSpeed * Time.deltaTime;// �Ӱ� �� �վ����� ���v�� 
        rb.AddForce(direction * moveSpeed, ForceMode.Force);
      
    }
}

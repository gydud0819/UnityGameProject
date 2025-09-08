using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed = 10f;
    //private Transform transform;    // transform�� ���ο� ����Ǿ� �ֱ� ������ ���� �����ؼ� �� �ʿ䰡 ��..��? �ƴѰŰ������� 
    private void Start()
    {
        transform.position = new Vector3(1, 1, 1);
        Debug.Log($"position : {transform.position}");
    }

    private void Update()
    {

        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    transform.position += Vector3.forward; // ? �� �� ���ä��ä�����
        //}
        //else if (Input.GetKeyDown(KeyCode.S))
        //{
        //    transform.position += Vector3.back;
        //}
        //else if (Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.position += Vector3.left;
        //}
        //else if (Input.GetKeyDown(KeyCode.D))
        //{
        //    transform.position += Vector3.right;
        //}

        // direction �������� �� �վ���ϳ�

        // P = P0 + vt
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        // ������ ũ�⸦ 1�� �����Ѵ�.
        direction.Normalize();

        // Time.deltaTime
        // ������ ������ ������ �Ϸ�Ǵ� �ð�

        transform.position += direction * speed * Time.deltaTime;


    }
}

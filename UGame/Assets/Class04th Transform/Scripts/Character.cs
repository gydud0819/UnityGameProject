using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed = 10f;
    //private Transform transform;    // transform이 내부에 선언되어 있기 때문에 굳이 선언해서 쓸 필요가 없..다? 아닌거같은ㄴ데 
    private void Start()
    {
        transform.position = new Vector3(1, 1, 1);
        Debug.Log($"position : {transform.position}");
    }

    private void Update()
    {

        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    transform.position += Vector3.forward; // ? 얘 뭐 ㅇㅓㅉㅓㄹㅏ고
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

        // direction 변수말고 또 잇어야하나

        // P = P0 + vt
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        // 벡터의 크기를 1로 설정한다.
        direction.Normalize();

        // Time.deltaTime
        // 마지막 프레임 이후의 완료되는 시간

        transform.position += direction * speed * Time.deltaTime;


    }
}

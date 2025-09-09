using System;
using UnityEngine;
[RequireComponent(typeof(Move))]        // RequireComponent 자동으로 붙여주는 컴포넌트 개쩐당 히히 

public class Character : MonoBehaviour
{
   
    [SerializeField] Move move;
    //private Transform transform;    // transform이 내부에 선언되어 있기 때문에 굳이 선언해서 쓸 필요가 없..다? 아닌거같은ㄴ데 

    private void Awake()
    {
        move = GetComponent<Move>();
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


        move.OnMove(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")));
        // 벡터의 크기를 1로 설정한다.
        //direction.Normalize();

        // Time.deltaTime
        // 마지막 프레임 이후의 완료되는 시간

       

       

        
        
    }

    

}

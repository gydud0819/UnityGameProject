using System;
using UnityEngine;
[RequireComponent(typeof(Move))]        // RequireComponent �ڵ����� �ٿ��ִ� ������Ʈ ��¾�� ���� 

public class Character : MonoBehaviour
{
   
    [SerializeField] Move move;
    //private Transform transform;    // transform�� ���ο� ����Ǿ� �ֱ� ������ ���� �����ؼ� �� �ʿ䰡 ��..��? �ƴѰŰ������� 

    private void Awake()
    {
        move = GetComponent<Move>();
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


        move.OnMove(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")));
        // ������ ũ�⸦ 1�� �����Ѵ�.
        //direction.Normalize();

        // Time.deltaTime
        // ������ ������ ������ �Ϸ�Ǵ� �ð�

       

       

        
        
    }

    

}

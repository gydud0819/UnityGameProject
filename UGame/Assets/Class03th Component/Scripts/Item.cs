using System;
using UnityEditor.UIElements;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    // new�� ����Ӵ��� ������ �װ� ���⿡ �ǳ�..? �� �ƴϳ� ��
    // ���콺 ��Ŭ���ϸ� ������ ���� ������ �ϱ� 
    // GetKeyDown.LeftMouse ��¼�� 

    public abstract void Activate();

}

using System;
using UnityEditor.UIElements;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    // new로 갖고왓던거 같은데 그게 여기에 되나..? 다 아니네 썅
    // 마우스 좌클릭하면 아이템 정보 나오게 하기 
    // GetKeyDown.LeftMouse 어쩌고 

    public abstract void Activate();

}

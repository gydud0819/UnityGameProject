using UnityEngine;

public class Flintlock : Item
{
    public override void Activate()
    {
        Debug.Log("한번쓸때마다 쿨타임 120초 도는 것");
    }

}

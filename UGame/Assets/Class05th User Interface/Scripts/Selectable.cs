using UnityEngine;
using UnityEngine.UI;

using UnityEngine.EventSystems;

public class Selectable : MonoBehaviour
{
    // �̰� �������̾ߤ�;;;;;;;;;;
   [SerializeField] Button[] button;

    public void Enter()
    {
        button[0].GetComponentInChildren<Text>().fontSize = 100;
    }
    public void Exit()
    {
        button[1].GetComponentInChildren<Text>().fontSize = 75;
    }

    public void Down()
    {
        button[2].GetComponentInChildren<Text>().fontSize = 50;

    }
}

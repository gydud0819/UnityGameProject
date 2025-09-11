using UnityEngine;
using UnityEngine.UI;

using UnityEngine.EventSystems;

public class Selectable : MonoBehaviour
{
    // �̰� �������̾ߤ�;;;;;;;;;;
   [SerializeField] Text titleText;

    private void Awake()
    {
        titleText = GetComponentInChildren<Text>();
    }

    public void Enter()
    {
        titleText.fontSize = 100; // 
    }

    public void Exit()
    {
        titleText.fontSize = 75; // 
       
    }

    public void Down()
    { 
        titleText.fontSize = 50; // 

    }
}

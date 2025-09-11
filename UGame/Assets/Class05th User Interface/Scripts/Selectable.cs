using UnityEngine;
using UnityEngine.UI;

using UnityEngine.EventSystems;

public class Selectable : MonoBehaviour
{
    // 이게 무슨말이야ㅏ;;;;;;;;;;
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

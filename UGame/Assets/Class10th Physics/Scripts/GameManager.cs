using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score;
   
    // ����? �浹���� �� ���� �ø���? 
   public void Stay()
    {
        score++;
        // �浹������ �ø��°Ÿ�
        Debug.Log("score : " + score);
    }
}
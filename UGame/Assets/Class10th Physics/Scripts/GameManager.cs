using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score;
   
    // 점수? 충돌했을 때 점수 올리기? 
   public void Stay()
    {
        score++;
        // 충돌햇을때 올리는거면
        Debug.Log("score : " + score);
    }
}
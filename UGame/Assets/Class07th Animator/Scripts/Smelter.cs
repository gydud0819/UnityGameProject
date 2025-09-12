using UnityEngine;

public class Smelter : MonoBehaviour
{
    [SerializeField] float maxValue;     // 이게 아닌가
    [SerializeField] int Count;
    public void Success()
    {
        Debug.Log("Successed");
    }

    public void Process(float progress)     // 10번 실행이 되야하는데 ㅓ........
    {
        // 100이되면 완성출력 및 다시 0으로 만들기
        // 누적 += 이거 아님? 
        maxValue += progress;
        Debug.Log("Progress : " + maxValue + "%");

        if (maxValue >= 100)
        {
            maxValue = 0.0f;
        }

    }

    public void Enchant(int count)
    {
        Count += count;

        Debug.Log("강화 횟수 : " + Count);

    }
}

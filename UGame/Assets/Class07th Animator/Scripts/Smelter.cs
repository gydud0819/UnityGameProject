using UnityEngine;

public class Smelter : MonoBehaviour
{
    [SerializeField] float maxValue;     // �̰� �ƴѰ�
    [SerializeField] int Count;
    public void Success()
    {
        Debug.Log("Successed");
    }

    public void Process(float progress)     // 10�� ������ �Ǿ��ϴµ� ��........
    {
        // 100�̵Ǹ� �ϼ���� �� �ٽ� 0���� �����
        // ���� += �̰� �ƴ�? 
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

        Debug.Log("��ȭ Ƚ�� : " + Count);

    }
}

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public int timeLimit = 60; // Ÿ�̸��� ���� �ð� (��)
    private float currentTime; // ���� �ð�
    private bool isTimerRunning; // Ÿ�̸� ���� ����

    public TextMeshProUGUI timerText; // UI �ؽ�Ʈ ������Ʈ

    void Start()
    {
        // Ÿ�̸� �ʱ�ȭ
        ResetTimer();
    }

    void Update()
    {
        if (isTimerRunning)
        {
            // ���� �ð� ����
            currentTime -= Time.deltaTime;

            // �ð��� 0 ���ϸ� Ÿ�̸� ����
            if (currentTime <= 0f)
            {
                currentTime = 0;
                isTimerRunning = false;
                // Ÿ�̸� ����� ���ϴ� ���� ����
                // ��: ���� ����, ���� ���� ��
            }

            // UI ������Ʈ
            UpdateUITimer();
        }
    }

    void ResetTimer()
    {
        // Ÿ�̸� �ʱ�ȭ
        currentTime = timeLimit;
        isTimerRunning = true;
    }

    void UpdateUITimer()
    {
        // UI �ؽ�Ʈ ������Ʈ
        timerText.text = "���� �ð�: " +
            Mathf.CeilToInt(currentTime).ToString() + "��";
    }
}

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public int timeLimit = 60; // 타이머의 제한 시간 (초)
    private float currentTime; // 현재 시간
    private bool isTimerRunning; // 타이머 실행 여부

    public TextMeshProUGUI timerText; // UI 텍스트 오브젝트

    void Start()
    {
        // 타이머 초기화
        ResetTimer();
    }

    void Update()
    {
        if (isTimerRunning)
        {
            // 현재 시간 갱신
            currentTime -= Time.deltaTime;

            // 시간이 0 이하면 타이머 종료
            if (currentTime <= 0f)
            {
                currentTime = 0;
                isTimerRunning = false;
                // 타이머 종료시 원하는 동작 수행
                // 예: 보스 등장, 게임 종료 등
            }

            // UI 업데이트
            UpdateUITimer();
        }
    }

    void ResetTimer()
    {
        // 타이머 초기화
        currentTime = timeLimit;
        isTimerRunning = true;
    }

    void UpdateUITimer()
    {
        // UI 텍스트 업데이트
        timerText.text = "남은 시간: " +
            Mathf.CeilToInt(currentTime).ToString() + "초";
    }
}

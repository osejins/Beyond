using UnityEngine;
using UnityEngine.SceneManagement; // 씬 전환 기능을 사용하기 위해 필수

public class SceneChanger : MonoBehaviour
{
    [Header("설정")]
    [Tooltip("이동할 씬의 이름을 정확히 입력하세요.")]
    public string nextSceneName = "HQScene"; // 이동할 씬 이름

    [Tooltip("자동으로 전환되기까지 기다릴 시간(초)")]
    public float waitTime = 30.0f; // 대기 시간 (30초)

    private float currentTimer = 0.0f;
    private bool isTransitioning = false; // 중복 실행 방지용 플래그

    void Update()
    {
        // 이미 씬 전환이 시작되었다면 아무것도 하지 않음
        if (isTransitioning) return;

        // 1. 시간 측정 (매 프레임 흐른 시간을 더함)
        currentTimer += Time.deltaTime;

        // 2. 조건 검사: (시간이 30초 이상 지났거나) 또는 (스페이스바를 눌렀을 때)
        if (currentTimer >= waitTime || Input.GetKeyDown(KeyCode.Space))
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        Debug.Log("씬을 전환합니다: " + nextSceneName);
        isTransitioning = true;

        // 지정된 이름의 씬을 불러오기
        SceneManager.LoadScene(nextSceneName);
    }
}
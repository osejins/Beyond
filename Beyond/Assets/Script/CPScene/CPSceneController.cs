using UnityEngine;
using UnityEngine.SceneManagement;

public class CPSceneController : MonoBehaviour
{
    [Header("씬 전환 설정")]
    // 이동할 씬 이름: ApoScene
    public string nextSceneName = "ApoScene";

    // 대기 시간: 30초
    public float waitTime = 30.0f;

    private float timer = 0.0f;
    private bool isTransitioning = false;

    void Update()
    {
        // 중복 실행 방지
        if (isTransitioning) return;

        // 1. 시간 흐름 측정
        timer += Time.deltaTime;

        // 2. 30초가 지났거나 OR 스페이스바를 눌렀을 때
        if (timer >= waitTime || Input.GetKeyDown(KeyCode.Space))
        {
            MoveToApoScene();
        }
    }

    void MoveToApoScene()
    {
        isTransitioning = true;
        // ApoScene으로 이동
        SceneManager.LoadScene(nextSceneName);
    }
}
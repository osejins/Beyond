using UnityEngine;
using UnityEngine.SceneManagement;

public class HQSceneController : MonoBehaviour
{
    // 60초와 PrincessScene으로 미리 설정해 두었습니다.
    public string nextSceneName = "PrincessScene";
    public float waitTime = 60.0f;

    private float timer = 0.0f;
    private bool isTransitioning = false;

    void Update()
    {
        if (isTransitioning) return;

        // 시간 흐름 측정
        timer += Time.deltaTime;

        // 60초가 지났거나 OR 스페이스바를 눌렀을 때
        if (timer >= waitTime || Input.GetKeyDown(KeyCode.Space))
        {
            MoveToNextScene();
        }
    }

    void MoveToNextScene()
    {
        isTransitioning = true;
        SceneManager.LoadScene(nextSceneName);
    }
}
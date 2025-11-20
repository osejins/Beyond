using UnityEngine;
using UnityEngine.SceneManagement;

public class PrincessSceneController : MonoBehaviour
{
    [Header("씬 전환 설정")]
    // 이동할 씬 이름을 미리 CartoonScene으로 설정해 뒀습니다.
    public string nextSceneName = "CartoonScene";

    // 대기 시간을 30초로 설정했습니다.
    public float waitTime = 30.0f;

    private float timer = 0.0f;
    private bool isTransitioning = false;

    void Update()
    {
        // 이미 전환 중이면 중복 실행 방지
        if (isTransitioning) return;

        // 시간 누적
        timer += Time.deltaTime;

        // 30초가 지났거나 OR 스페이스바를 눌렀을 때
        if (timer >= waitTime || Input.GetKeyDown(KeyCode.Space))
        {
            MoveToCartoonScene();
        }
    }

    void MoveToCartoonScene()
    {
        isTransitioning = true;
        // 설정된 씬(CartoonScene)으로 이동
        SceneManager.LoadScene(nextSceneName);
    }
}
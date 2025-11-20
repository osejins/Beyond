using UnityEngine;
using UnityEngine.SceneManagement;

public class CartoonSceneController : MonoBehaviour
{
    [Header("설정")]
    // 이동할 씬 이름: CPScene
    public string nextSceneName = "CPScene";

    // 대기 시간: 30초
    public float waitTime = 30.0f;

    private float timer = 0.0f;
    private bool isTransitioning = false;

    void Update()
    {
        if (isTransitioning) return;

        // 시간 흐름 측정
        timer += Time.deltaTime;

        // 30초가 지났거나 OR 스페이스바를 눌렀을 때
        if (timer >= waitTime || Input.GetKeyDown(KeyCode.Space))
        {
            MoveToCPScene();
        }
    }

    void MoveToCPScene()
    {
        isTransitioning = true;
        // CPScene으로 이동
        SceneManager.LoadScene(nextSceneName);
    }
}
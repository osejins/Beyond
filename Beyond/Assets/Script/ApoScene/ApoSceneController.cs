using UnityEngine;
using UnityEngine.SceneManagement;

public class ApoSceneController : MonoBehaviour
{
    [Header("씬 전환 설정")]
    // 이동할 씬 이름: MRScene으로 변경
    public string nextSceneName = "MRScene";

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

        // 2. 조건 확인
        // (1) 30초가 지났거나 
        // (2) 키보드 스페이스바를 눌렀거나 (PC 테스트용)
        // (3) 퀘스트 컨트롤러 A버튼을 눌렀을 때 (VR 테스트용 - OVRInput 필요 시 주석 해제)
        if (timer >= waitTime || Input.GetKeyDown(KeyCode.Space) /* || OVRInput.GetDown(OVRInput.Button.One) */)
        {
            MoveToNextScene();
        }
    }

    void MoveToNextScene()
    {
        isTransitioning = true;
        Debug.Log($"[ApoSceneController] {waitTime}초 경과 또는 입력 감지! {nextSceneName}으로 이동합니다.");
        SceneManager.LoadScene(nextSceneName);
    }
}
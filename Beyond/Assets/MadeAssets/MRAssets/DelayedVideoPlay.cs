using System.Collections;
using UnityEngine;

public class DelayedVideoActivator : MonoBehaviour
{
    [Header("활성화할 비디오 오브젝트")]
    public GameObject videoObject; // 여기에 비디오 오브젝트를 연결합니다.

    [Header("지연 시간 (초)")]
    public float delayTime = 64f; // 64초로 설정

    void Start()
    {
        // 씬 시작 시 비디오 오브젝트가 켜져 있다면 끕니다 (선택 사항)
        if (videoObject != null)
        {
            videoObject.SetActive(false); 
        }

        // 64초 카운트다운 코루틴 시작
        StartCoroutine(ActivateVideoAfterDelay());
    }

    // 지정된 시간만큼 기다렸다가 오브젝트를 켜는 함수
    IEnumerator ActivateVideoAfterDelay()
    {
        // 64초 동안 대기
        yield return new WaitForSeconds(delayTime);

        // 비디오 오브젝트 활성화
        if (videoObject != null)
        {
            videoObject.SetActive(true);
            Debug.Log("64초가 지나 비디오 오브젝트가 활성화되었습니다.");
        }
    }
}
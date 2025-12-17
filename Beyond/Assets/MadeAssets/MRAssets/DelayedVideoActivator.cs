using System.Collections;
using UnityEngine;

public class DelayedVideoActivator : MonoBehaviour
{
    public GameObject screenObject; // 비디오가 나오는 스크린 오브젝트
    public float delayTime = 66f;   // 64초 대기

    void Start()
    {
        // 1. 게임 시작하자마자 스크린을 일단 숨깁니다.
        if (screenObject != null)
        {
            screenObject.SetActive(false);
        }

        // 2. 64초 카운트다운을 시작합니다.
        StartCoroutine(WaitAndPlay());
    }

    IEnumerator WaitAndPlay()
    {
        // 64초 동안 아무것도 안 하고 기다림
        yield return new WaitForSeconds(delayTime);

        // 3. 시간이 되면 스크린을 켭니다 (이때 Video Player의 Play On Awake 덕분에 영상이 자동 재생됨)
        if (screenObject != null)
        {
            screenObject.SetActive(true);
        }
    }
}
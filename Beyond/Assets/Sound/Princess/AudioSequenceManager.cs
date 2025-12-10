using System.Collections;
using UnityEngine;

public class AudioSequenceManager : MonoBehaviour
{
    [Header("오디오 소스 연결")]
    public AudioSource audioSource;

    [Header("오디오 클립 파일들")]
    public AudioClip clip_S3_1;
    public AudioClip clip_S3_2;

    void Start()
    {
        StartCoroutine(PlayAudioFlow());
    }

    IEnumerator PlayAudioFlow()
    {
        // 1. 씬 시작 후 1초 대기는 유지 (처음에 원하셨던 조건)
        yield return new WaitForSeconds(1.0f);

        // 2. S#3-1 재생
        audioSource.clip = clip_S3_1;
        audioSource.Play();

        // 3. S#3-1이 끝날 때까지 기다림
        yield return new WaitForSeconds(clip_S3_1.length);

        // ★ 수정된 부분: 여기서 1초 쉬는 코드를 삭제했습니다.
        // S#3-1이 끝나자마자 바로 아래 코드가 실행됩니다.

        // 4. S#3-2 재생 (바로 이어서 나옴)
        audioSource.clip = clip_S3_2;
        audioSource.Play();
    }
}
using System.Collections;
using System.Collections.Generic; // 리스트를 쓰기 위해 필요해요
using UnityEngine;

public class HQAudioPlayer : MonoBehaviour
{
    [Header("오디오 소스 (스피커)")]
    public AudioSource audioSource;

    [Header("재생할 오디오 목록 (순서대로 넣으세요)")]
    // 오디오 클립을 여러 개 담을 수 있는 리스트입니다.
    public List<AudioClip> audioPlaylist;

    void Start()
    {
        // 씬이 시작되면 코루틴 가동!
        StartCoroutine(PlayAudioSequence());
    }

    IEnumerator PlayAudioSequence()
    {
        // 1. 씬 시작 후 1초 대기 (요청하신 부분)
        yield return new WaitForSeconds(1.0f);

        // 2. 리스트에 있는 오디오들을 하나씩 꺼내서 순서대로 재생
        foreach (AudioClip clip in audioPlaylist)
        {
            if (clip != null)
            {
                audioSource.clip = clip;
                audioSource.Play();

                // 오디오 길이만큼 기다렸다가 다음으로 넘어감 (바로 연달아 재생)
                yield return new WaitForSeconds(clip.length);
            }
        }

        // 3. 모든 재생이 끝남!
        Debug.Log("모든 오디오 재생 완료");
    }
}
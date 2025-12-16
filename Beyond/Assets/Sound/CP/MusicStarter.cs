using UnityEngine;
using System.Collections;

public class HQAudioController : MonoBehaviour
{
    public AudioSource myAudio;

    [Header("시간 설정")]
    public float waitSeconds = 24.0f; // 대기 시간 (24초)
    public float playDuration = 9.0f; // ★재생 시간 (9초)★

    void Start()
    {
        if (myAudio.isPlaying) myAudio.Stop();
        myAudio.playOnAwake = false;

        StartCoroutine(PlayMusicRoutine());
    }

    IEnumerator PlayMusicRoutine()
    {
        // 24초 기다림
        yield return new WaitForSeconds(waitSeconds);

        // 재생
        myAudio.Play();

        // 9초 동안 틀어놓음
        yield return new WaitForSeconds(playDuration);

        // 끔
        myAudio.Stop();
    }
}
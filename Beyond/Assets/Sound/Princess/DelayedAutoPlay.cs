using UnityEngine;
using System.Collections;

public class DelayedAutoPlay : MonoBehaviour
{
    public AudioSource myAudioSource;

    // 인스펙터 창에서 시간을 마음대로 조절할 수 있게 변수를 만들었습니다.
    // 기본값은 1초입니다.
    public float delayTime = 1.0f;

    void Start()
    {
        StartCoroutine(PlaySoundAfterDelay());
    }

    IEnumerator PlaySoundAfterDelay()
    {
        // 위에서 설정한 시간(1초)만큼 기다립니다.
        yield return new WaitForSeconds(delayTime);

        if (myAudioSource != null)
        {
            myAudioSource.Play();
            Debug.Log(delayTime + "초가 지나서 오디오가 재생되었습니다.");
        }
    }
}
using UnityEngine;

public class PlaySoundAfterDelay : MonoBehaviour
{
    public AudioSource myAudio; // 여기에 오디오 소스를 연결합니다.

    void Start()
    {
        if (myAudio != null)
        {
            // 씬 시작 후 24초 뒤에 오디오를 재생합니다.
            myAudio.PlayDelayed(24f);
        }
    }
}
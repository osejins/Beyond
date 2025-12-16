using UnityEngine;
using System.Collections;

public class VRSceneDirector : MonoBehaviour
{
    public Transform xrOrigin; // 움직일 대상 (XR Origin 전체)
    public Transform pos1;     // 뒷모습 자리
    public Transform pos2;     // 앞모습 자리

    void Start()
    {
        StartCoroutine(MoveCameraRoutine());
    }

    IEnumerator MoveCameraRoutine()
    {
        // [시작 0초] 뒷모습(Pos1)에서 시작
        xrOrigin.position = pos1.position;
        xrOrigin.rotation = pos1.rotation;

        // 👇 여기서 22초를 기다립니다 (뒷모습 보여주는 시간)
        yield return new WaitForSeconds(22.0f);

        // [22초 땡!] 앞모습(Pos2)으로 이동
        xrOrigin.position = pos2.position;
        xrOrigin.rotation = pos2.rotation;

        // 👇 여기서 24초를 기다립니다 (앞모습 보여주는 시간)
        yield return new WaitForSeconds(24.0f);

        // [46초 땡! (22+24)] 다시 뒷모습(Pos1)으로 복귀
        xrOrigin.position = pos1.position;
        xrOrigin.rotation = pos1.rotation;
    }
}
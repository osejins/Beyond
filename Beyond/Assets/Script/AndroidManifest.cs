using UnityEngine;
using UnityEngine.Android;

public class PermissionRequester : MonoBehaviour
{
    void Start()
    {
        // Quest 3 Passthrough 및 Scene API 관련 권한 요청
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }

        // Scene Mesh(MR Utility Kit) 사용 시 필요한 공간 데이터 권한
        if (!Permission.HasUserAuthorizedPermission("com.oculus.permission.USE_SCENE"))
        {
            Permission.RequestUserPermission("com.oculus.permission.USE_SCENE");
        }
    }
}
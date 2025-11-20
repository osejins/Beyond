using UnityEngine;

public class AutoWalker : MonoBehaviour
{
    public float moveSpeed = 1.8f;
    Animator anim;

    void Start() { anim = GetComponent<Animator>(); if (anim) anim.SetFloat("Speed", 1f); }

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.Self);
    }
}

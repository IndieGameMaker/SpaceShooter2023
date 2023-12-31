using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Transform firePos;
    public GameObject bulletPrefab;
    public AudioClip fireSfx;

    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        // 마우스 왼쪽 버튼 클릭했을 경우
        if (Input.GetMouseButtonDown(0) == true)
        {
            FireBullet();
        }
    }

    void FireBullet()
    {
        // 사운드 재생
        audio.PlayOneShot(fireSfx, 0.8f);

        // 총알을 생성
        Instantiate(bulletPrefab, firePos.position, firePos.rotation);
    }
}

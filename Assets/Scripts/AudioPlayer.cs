using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] AudioClip shootingClip;
    [SerializeField][Range(0, 1)] float shootingVolume = 0.5f;

    [Header("Taking Damage")]
    [SerializeField] AudioClip takingDamageClip;
    [SerializeField][Range(0, 1)] float takingDamageVolume = 0.5f;

    public void PlayShootingClip()
    {
        if (shootingClip != null)
        {
            PlayClip(shootingClip, shootingVolume);
        }
    }

    public void PlayDamageClip()
    {
        PlayClip(takingDamageClip, takingDamageVolume);
    }

    void PlayClip(AudioClip clip, float volume)
    {
        if (clip != null)
        {
            Vector3 cameraPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(clip, cameraPos, volume);
        }
    }
}

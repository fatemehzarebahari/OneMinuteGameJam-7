using UnityEngine;

public class awardBox : MonoBehaviour
{
    [SerializeField]
    AudioSource openBox;

    [SerializeField]
    AudioSource OctupusAudio;
    [SerializeField]
    ParticleSystem explosion;

    void OnCollisionEnter2D(Collision2D collision)
    {
        explosion.Play();
        openBox.Play();
        OctupusAudio.Play();
        StarShooter.DestroyAll();
    }
    
}

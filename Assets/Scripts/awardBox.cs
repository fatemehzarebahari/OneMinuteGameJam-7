using UnityEngine;

public class awardBox : MonoBehaviour
{
    [SerializeField]
    AudioSource openBox;

    [SerializeField]
    AudioSource OctupusAudio;

    void OnCollisionEnter2D(Collision2D collision)
    {
        openBox.Play();
        OctupusAudio.Play();
        StarShooter.DestroyAll();
    }
    
}

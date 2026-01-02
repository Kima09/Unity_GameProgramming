using UnityEngine;

public class Unit : MonoBehaviour
{
   
    [SerializeField] AudioSource audioSource;

    public void Emit()
    {
        audioSource.clip = Resources.Load<AudioClip>("Attack");

        audioSource.Play();
    }
}

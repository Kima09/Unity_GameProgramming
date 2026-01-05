using UnityEngine;

public enum AnimationState
{
    Idle,
    Walk,
    Attack,
    Die
}

public class Unit : MonoBehaviour
{
   
    [SerializeField] AudioSource audioSource;
    [SerializeField] Animator animator;

    [SerializeField] AnimationState state;
    [SerializeField] int index=0;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Transition(int count)
    {
        if(count ==0)
        {
            state = (AnimationState)((int)state % 3);
            return;
        }

        index += count;

        if(index %3 ==0)
        {
            state++;
        }
    }

    public void Emit()
    {

        Debug.Log(state.ToString());

        audioSource.clip = Resources.Load<AudioClip>(state.ToString());

        audioSource.Play();
    }
}

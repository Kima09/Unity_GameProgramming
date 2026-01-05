using UnityEngine;
using System;

public class CampFire : Equipment
{
    public event Action OnReset;
    [SerializeField] float size = 0.25f;

    private void OnEnable()
    {
        OnReset += Return;
        
    }
    public override void Operate()
    {
        transform.localScale -= new Vector3(size, size, size);

        if(transform.localScale == Vector3.zero)
        {
            OnReset?.Invoke();
        }
        
    }

    public void Return()
    {
        transform.localScale = Vector3.one;
    }

    private void OnDisable()
    {
        OnReset -= Return;
    }
}

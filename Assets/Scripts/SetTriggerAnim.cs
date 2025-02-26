using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTriggerAnim : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    public string triggername;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetTriggerNow()
    {
        _animator.SetTrigger(triggername);
    }

}

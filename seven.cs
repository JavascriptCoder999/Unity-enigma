using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animator : MonoBehaviour
{
    private Animator _animator;
    private Jump _jump;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _jump = GetComponent<Jump>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_jump.GetIsGrounded())
        {
            _animator.SetBool("isRunning", true);
            _animator.SetBool("isJumping", false);
        }
        else
        {
            _animator.SetBool("isRunning", false);
            _animator.SetBool("isJumping", true);
        }
    }
}

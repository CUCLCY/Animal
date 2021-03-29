using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    public string animalName;
    public string animalId;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAnim(string name)
    {
        animator.Play(name);
    }
}

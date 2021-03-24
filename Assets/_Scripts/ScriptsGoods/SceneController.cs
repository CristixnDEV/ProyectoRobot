using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Cambiar entre escenas y menus
    [SerializeField]private Animator animator;
    private float timingFade = 1f;
    public void ChangeEscene(string nameScene)
    {
        StartCoroutine(Wait(nameScene));
    }
    IEnumerator Wait (string nameScene)
    { 
        animator.Play("FadeOut");
        yield return new WaitForSeconds(timingFade);
        SceneManager.LoadScene(nameScene);
    }
}

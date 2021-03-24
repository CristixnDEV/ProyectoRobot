using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimingScene : MonoBehaviour
{
    // Para pantallas de carga
    [SerializeField]private float timingVideoDuration = 2;
    [SerializeField]private float timingFadeDuration = 1;
    [SerializeField]private string nameScene;
    [SerializeField]private Animator animator;

    private void Start()
    {
        StartCoroutine(WaitForSeconds(nameScene));
    }

    IEnumerator WaitForSeconds(string nameScene)
    {
        yield return new WaitForSeconds(timingVideoDuration);
        animator.Play("FadeOut");
        yield return new WaitForSeconds(timingFadeDuration);
        SceneManager.LoadScene(nameScene);
    }
}

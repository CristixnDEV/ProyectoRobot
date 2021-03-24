using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    // Pasa de un nivel a otro
    [SerializeField] private float timingFadeDuration = 1;
    [SerializeField] private Animator animator;
    [SerializeField] private string nameScene;
    private void OnTriggerEnter(Collider collider)
    {
        StartCoroutine(ChangeScene(nameScene));
    }
    IEnumerator ChangeScene(string nameScene)
    {
        animator.Play("FadeOut");
        yield return new WaitForSeconds(timingFadeDuration);
        SceneManager.LoadScene(nameScene);
    }
}

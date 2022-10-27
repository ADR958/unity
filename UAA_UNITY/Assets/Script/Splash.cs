using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    public bool startScene;

    private void Awake() {
        StartCoroutine(inicializaParaMainMenu());
    }

    private IEnumerator inicializaParaMainMenu(){
        yield return new WaitUntil(() => startScene);

        SceneManager.LoadScene("MainMenu");
    }
}

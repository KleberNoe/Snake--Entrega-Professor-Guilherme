using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    bool sceneHasStopped = false;
    void Update()
    {
        if(gameHasEnded && !sceneHasStopped)
        {
            StartCoroutine(RestartScene());
            return;
        }
    }

    IEnumerator RestartScene()
    {
        sceneHasStopped = true;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        gameHasEnded = true;
    }
}

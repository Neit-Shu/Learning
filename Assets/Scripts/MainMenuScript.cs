using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float xBound = 6f;
    [SerializeField] private float zBound = 5.3f;
    [SerializeField] private float destroyBorder = -15f;

    private GameObject ball;
    void Update()
    {
        BallSpawner();
        BallDestroy(destroyBorder);
    }
    private void BallSpawner()
    {
        if (ball != null)
        {
            return;
        }
        else
        {
            float rXBound = Random.Range(-xBound, xBound);
            float rZBound = Random.Range(-zBound, zBound);

            Vector3 ballPos = new Vector3(rXBound, transform.position.y, rZBound);

            ball = Instantiate(ballPrefab, ballPos, Quaternion.identity);
        }
    }

    private void BallDestroy (float value)
    {
        if(ball.transform.position.y < value)
        {
            Destroy(ball);
        }
    }

    public void AppExit()                                                           //6.0
    {
#if UNITY_EDITOR                                                                    //6.1
        UnityEditor.EditorApplication.ExitPlaymode();                               //6.2
#endif                                                                              //6.3

        Application.Quit();                                                         //6.4

        Debug.Log("Exit");                                                          //6.5
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(1);
    }
}

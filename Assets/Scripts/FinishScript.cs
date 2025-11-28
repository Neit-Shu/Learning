using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishScript : MonoBehaviour
{
    [SerializeField] private GameObject congrats;
    void Start()
    {
        Congrats(false);
    }

    private void OnTriggerStay()
    {
        Congrats(true);
        Invoke("AppExit", 3f);
    }
    public void AppExit()                                                           //6.0
    {
#if UNITY_EDITOR                                                                    //6.1
        UnityEditor.EditorApplication.ExitPlaymode();                               //6.2
#endif                                                                              //6.3

        Application.Quit();                                                         //6.4

        Debug.Log("Exit");                                                          //6.5
    }
    void Congrats(bool state)
    {
        congrats.SetActive(state);
    }
}

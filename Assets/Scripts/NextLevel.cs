using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private GameObject congrats;
    void Start()
    {
        Congrats(false);
    }

    private void OnTriggerStay()
    {
        Congrats(true);
        Invoke("NextLvl", 3f);
    }
   void NextLvl()
    {
        SceneManager.LoadScene(2);
    }
    void Congrats(bool state)
    {
        congrats.SetActive(state);
    }
}

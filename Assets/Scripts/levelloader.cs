using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelloader : MonoBehaviour
{
    [SerializeField]
    public GameObject[] todisable;

    public GameObject[] toenable;

   

    public void loadLevel(int scenceindex)
    {
        StartCoroutine(loadInsync(scenceindex));
       
    }

    public void reloadlevel()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



    IEnumerator loadInsync(int scenceindex)
    {
       
        AsyncOperation operation = SceneManager.LoadSceneAsync(scenceindex);

        while (!operation.isDone)
        {
           // Debug.Log(operation.progress);
            foreach(GameObject gameobjects in todisable)
            {
                gameobjects.SetActive(false);
            }
            foreach (GameObject gameobjects in toenable)
            {
                gameobjects.SetActive(true);
            }

            yield return null;
        }


    }
}

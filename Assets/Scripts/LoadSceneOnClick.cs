using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{

    // Use this for initialization
    public void LoadByIndex(int sceneIndex)
    {

        //  System.Threading.Thread.Sleep(4000);

        SceneManager.LoadScene(sceneIndex);
    }


 //  public Animation LoadAnim;
 //  IEnumerator Start(int sceneIndex)
 //  {
 //      LoadAnim = GetComponent<Animation>();
 //      LoadAnim.Play();
 //      yield return new WaitForSeconds(LoadAnim.clip.length);
 //      SceneManager.LoadScene(sceneIndex);
 //  }

}

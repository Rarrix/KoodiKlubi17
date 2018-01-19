using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{

    public AudioSource DeathSoundSource;
    public AudioClip DeathSound;
    public GameObject Camera;
    public Animation Death;
    public Animator Animator;



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "vihree" || other.gameObject.tag == "oranssi"  )
        {
           Camera.GetComponent<Animation>().Play();
         Death.Play();
            DeathSoundSource.PlayOneShot(DeathSound);
            Debug.Log("hit");
            
            //Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }
        else
        {

        }
    }

}

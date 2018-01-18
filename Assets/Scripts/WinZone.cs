using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinZone : MonoBehaviour
{
   public bool vihree = false;
   public bool oranssi = false;

    void Update()
    {
        if (vihree && oranssi)
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(7);
        } 
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "oranssi")
        {
            oranssi = true;
           
        }
        else if (other.gameObject.tag == "vihree")
        {
            vihree = true;
        }

        else
        {
            oranssi = false;
            vihree = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        oranssi = false;
        vihree = false;
    }

}

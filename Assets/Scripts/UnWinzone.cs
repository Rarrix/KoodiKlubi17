using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnWinzone : MonoBehaviour
{
    public bool vihree = false;
    public bool oranssi = false;

 
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "oranssi")
        {
            Debug.Log("oranssi osu unwin");
            oranssi = false;

        }
        else if (other.gameObject.tag == "vihree")
        {
            Debug.Log("vihree osu unwin");
            vihree = false;
        }

    }

    void OnTriggerExit(Collider other)
    {
        oranssi = false;
        vihree = false;
    }

}

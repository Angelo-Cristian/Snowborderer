using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrushDetector : MonoBehaviour
{
    [SerializeField] float delay;
    [SerializeField] ParticleSystem bloodEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground")
        {
            bloodEffect.Play();
            Invoke("ReloadScene", delay);
        }
           
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

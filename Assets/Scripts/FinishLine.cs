using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delay;
    [SerializeField] ParticleSystem winningEffect;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            winningEffect.Play();
             Invoke("ReloadScene", delay);
        }
           
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

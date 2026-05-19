using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float TorqueAmmount;
    [SerializeField] float BoostSpeed = 30f;
    [SerializeField] float NormalSpeed = 20f;
    SurfaceEffector2D se2d;
    // Start is called before the first frame update
    void Start()
    {
        se2d = FindObjectOfType<SurfaceEffector2D>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
        BoostControl();
    }

    void Rotation()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
            rb2d.AddTorque(TorqueAmmount * Time.deltaTime);
        else
        if(Input.GetKey(KeyCode.RightArrow))
            rb2d.AddTorque(-TorqueAmmount * Time.deltaTime);
    }

    void BoostControl()
    {
        if(Input.GetKey(KeyCode.UpArrow))
            se2d.speed = BoostSpeed;
        else
            se2d.speed = NormalSpeed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    [SerializeField] float movespeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAmount = Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;
        transform.Translate(moveAmount,0,0);
    }
}

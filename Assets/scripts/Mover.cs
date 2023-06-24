using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

[SerializeField] float sichqare = 8f;
    // Start is called before the first frame update
    void Start()
    {
       printInstruction();
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void printInstruction()
    {
    Debug.Log("WELCOME TO THE GAME");
    Debug.Log("Forward 'W' back 'S'  Left 'A' Right 'D'");
    }

void MovePlayer()
    {
    float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * sichqare;
    float zValue = Input.GetAxis("Vertical") * Time.deltaTime * sichqare;
    transform.Translate(xValue,0,zValue);
    }

}

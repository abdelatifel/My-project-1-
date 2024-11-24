using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float moveSpeed = 5f;

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
        Debug.Log("welcome to the game");
        Debug.Log("move the player with wasd and arrow");
        Debug.Log("don not hit the walls");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private BoxCollider2D collider;
    [SerializeField] private BoxCollider2D playerCollider;

    // Start is called before the first frame update

    private void FixedUpdate()
    {
        //move coin to the left
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        
        

    }
}

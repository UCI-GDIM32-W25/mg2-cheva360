using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private BoxCollider2D ground;
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private int coinValue = 0;
    [SerializeField] private TextMeshProUGUI coinTextObject;
    [SerializeField] private float spawnTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player is grounded
        bool isGrounded = rb.IsTouching(ground);
        //on space press add jump force to 2d rigidbody
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        }
        //if player collides with object tagged as Coin increase coin value
        



    }
    private void FixedUpdate()
    {
        //make a timer that counts up to a random number between 1 and 2 seconds and then sets the variable back to 0
        spawnTimer += Time.fixedDeltaTime;
        if (spawnTimer >= Random.Range(.2f, 10f))
        {
            spawnTimer = 0f;
            Instantiate(coinPrefab, new Vector3(-2, (float)12.6, 0), Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coinValue++;
            coinTextObject.text = "" + coinValue;
        }
    }
}

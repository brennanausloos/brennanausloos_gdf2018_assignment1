using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    // Use this for initialization
    public float speed;

    private Rigidbody2D rb2d;

    public Text DiamondText;
    public Text MeteorText;
    public Text AsteroidText;
    public Text TotalScore;

    private int DiamondCount;
    private int MeteorCount;
    private int AsteroidCount;
    private int TotalScoreCount;

    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();

        DiamondCount = 0;

        MeteorCount = 0;

        AsteroidCount = 0;

        TotalScoreCount = 0;

        SetCountText();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb2d.AddForce(movement * speed);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);

            DiamondCount = DiamondCount + 1;

            SetCountText();

            TotalScoreCount = TotalScoreCount + 1;

            SetCountText();
        }


        if (other.gameObject.CompareTag("PickUp2"))
        {
            other.gameObject.SetActive(false);

            MeteorCount = MeteorCount + 1;

            SetCountText();

            TotalScoreCount = TotalScoreCount + 1;

            SetCountText();
        }

        if (other.gameObject.CompareTag("PickUp3"))
        {
            other.gameObject.SetActive(false);

            AsteroidCount = AsteroidCount + 1;

            SetCountText();

            TotalScoreCount = TotalScoreCount + 1;

            SetCountText();
        }
    }
    void SetCountText()
    {
        DiamondText.text = "Diamond Count: " + DiamondCount.ToString();

        MeteorText.text = "Meteor Count: " + MeteorCount.ToString();

        AsteroidText.text = "Asteroid Count: " + AsteroidCount.ToString();

        TotalScore.text = "Total Score: " + TotalScoreCount.ToString();
    
    
    
    }

}
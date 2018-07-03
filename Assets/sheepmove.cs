using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class sheepmove : MonoBehaviour
{

    public float speed = 10f;
    public float tilt = 4f;
    public float xMin = -6f;
    public float xMax = 6f;
    public float zMin = -4;
    public float zMax = 8;

    public Text FinishText;
    public Text ScoreText;
    public Text ExplainText;

    private int score;

    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        score = 10;
        SetCountText();
        FinishText.text = "";
        ExplainText.text = "←↑→↓ : 移動";

    }

    // Update is called once per frame
    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        rb.velocity = speed * new Vector3(moveHorizontal, 0f, moveVertical);
        rb.position = new Vector3(Mathf.Clamp(rb.position.x, xMin, xMax), 0f, Mathf.Clamp(rb.position.z, zMin, zMax));
        //rb.rotation = Quaternion.Euler(0f, 0f, rb.velocity.x * -tilt);

    }

    void OnCollisionEnter(Collider other)
    {
        if (other.gameObject.tag == "Boundary")
        {
            Destroy(other.gameObject);

            score = score + 1;

            SetCountText();

        }
    }

    void SetCountText()
    {
        ScoreText.text = "Score: " + score.ToString();
        if (score >= 80)
        {
            FinishText.text = "You Win!";

        }
    }
}

using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;

    GameManager gm;
    Rigidbody rb;
    bool xMov = true;
    bool canMove;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gm = FindObjectOfType<GameManager>();
        gm.AddEventToGameStart(delegate { canMove = true; });
        gm.AddEventToGameEnd(delegate { canMove = false; });
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove && Input.GetMouseButtonDown(0))
        {
            xMov = !xMov; 
            if(xMov)
            {
                MovingX(); 
            } else
            {
                MovingZ();
            }
        }
    }

    void MovingX()
    {
        rb.velocity = speed * Vector3.right;
    }

    void MovingZ()
    {
        rb.velocity = speed * Vector3.forward;
    }
    public void SetGameOver()
    {
        rb.useGravity = true;
        Invoke("DestroyBall", 5f);
    }

    void DestroyBall()
    {
        Destroy(gameObject);
    }
}

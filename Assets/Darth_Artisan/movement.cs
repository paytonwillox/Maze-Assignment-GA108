using UnityEngine;

public class movekitty : MonoBehaviour
{
    public float movespeed = 5f;
    private Rigidbody rb;
    private Vector3 move;
    //im tryna make my kitty run
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        move = new Vector3(h, 0, v);
        transform.Translate(move* movespeed * Time.deltaTime);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "TransitionBox")
        {
            mover.Instance.sceneToMoveTo();
        }
    }
}
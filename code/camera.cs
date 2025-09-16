using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    Vector3 offset;
    Vector3 newpos;
    public GameObject player;
    //called before first frame update

    void Start()
    {
        offset=player.transform.position-transform.position;
    }

    void Update()
    {
        transform.position=player.transform.position-offset;
    }
}

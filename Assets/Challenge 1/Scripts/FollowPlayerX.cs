using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject Plane;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Plane.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Plane.transform.position + offset;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    public Vector3 dir;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        keyInput();
    }

    void keyInput()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");


        Move();
    }
    private void Move()
    {

        transform.position += dir * speed * Time.deltaTime;
    }
}

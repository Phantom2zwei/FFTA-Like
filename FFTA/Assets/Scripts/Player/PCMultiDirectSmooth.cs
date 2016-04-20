using UnityEngine;
using System.Collections;

public class PCMultiDirectSmooth : MonoBehaviour
{
    Rigidbody2D RG;
    float speed = 10;
    void Start()
    {
        RG = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        float moveHori = Input.GetAxisRaw("Horizontal"), moveVerti = Input.GetAxisRaw("Vertical");
       // transform.position = new Vector3(transform.position.x + moveHori * Time.deltaTime * speed, transform.position.y + moveVerti * Time.deltaTime * speed, transform.position.z);
        transform.Translate(moveHori * Time.deltaTime * speed, moveVerti * Time.deltaTime * speed, 0);
    }

    float CalculeMove(float value)
    {
        if (value < 0)
            return -1;
        else if (value > 0)
            return 1;
        return 0;
    }
}
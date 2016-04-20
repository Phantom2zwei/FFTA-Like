using UnityEngine;
using System.Collections;

public class PCMultiDirectNoSmooth : MonoBehaviour
{
    Rigidbody2D RG;
    float speed = 200;
    void Start()
    {
        RG = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        float moveHori = Input.GetAxisRaw("Horizontal"), moveVerti = Input.GetAxisRaw("Vertical");
        RG.velocity = new Vector2(CalculeMove(moveHori) * speed * Time.deltaTime, CalculeMove(moveVerti) * speed * Time.deltaTime);
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
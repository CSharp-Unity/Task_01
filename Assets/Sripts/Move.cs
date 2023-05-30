using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private Rigidbody2D? rigidBody { get; set; }
    private Vector2? vector { get; set;} = null;
    public const float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        try
        {
           rigidBody = GetComponent<Rigidbody2D>();
           Debug.Log($"{System.DateTime.Now} : All Rigidbody Components is successful");
        }
        catch (System.Exception e)
        {
           Debug.LogError($"{System.DateTime.Now} : Get Component's is failed.\nBecause {e.Message}");
        }
    }

    // Update is called once per frame
    void Update()
    {
      float run = Input.GetAxis("Horizontal");
            vector = new Vector2(run , 0f) * speed;
            rigidBody.velocity = vector.GetValueOrDefault();
    }
}

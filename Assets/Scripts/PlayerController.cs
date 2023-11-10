using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = velocidade*Time.deltaTime;
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Vector2.right*deslocamento);
        }else if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(Vector2.left*deslocamento);
        }
        
    }
}

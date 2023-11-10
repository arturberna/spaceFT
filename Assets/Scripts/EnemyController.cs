using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
     public float velocidade = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = velocidade*Time.deltaTime;
        transform.Translate(Vector2.right*deslocamento);
    }
    void OnTriggerEnter2D(Collider2D body){
        
        if(body.gameObject.CompareTag("parede")){
            transform.position = new Vector3(transform.position.x,transform.position.y-1,transform.position.z);
            velocidade*=-1.0f;
            
        }

    }
}

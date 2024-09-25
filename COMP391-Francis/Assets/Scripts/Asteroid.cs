using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [Range(-2, 2)]
    public float minValue, maxValue;
 
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(minValue, maxValue);
        float y = Random.Range(minValue, maxValue);
        GetComponent<Rigidbody2D>().AddForce(new Vector2(x, y), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Missile"))
           
            
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }   
    }
}

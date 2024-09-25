using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // private is default until you put in public
    private float horizontalInput, verticalInput;
    public int speed;
    Vector2 newVelocity;
    public GameObject missile;

    // Start is called before the first frame update
    void Start()
    {
        // The f mean float, it's used when there are many decimals exp: 0.414314
        // Can also be written as: newVelocity = new Vector()
        newVelocity = new Vector2(0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        newVelocity.x = horizontalInput;
        newVelocity.y = verticalInput;

        GetComponent<Rigidbody2D>().velocity = newVelocity * speed;

        bool fireMissile = Input.GetButton("Fire1");
        if (fireMissile)
        {
            //create a copy of the missile gameobject
            Instantiate(missile, 
                position: new Vector3(transform.position.x, y:transform.position.y + 1f, z:0f),
                Quaternion.identity);
            
        }
    }

        }
    


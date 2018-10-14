
using UnityEngine;
using System.Collections;


public class balancemovement : MonoBehaviour {

    public Rigidbody2D body;
    public GameObject Stopper;
    public GameObject nameGameObject;
    private lost name;


    // Use this for initialization
    void Start () {
       name = GetComponent<lost>();
    }

    // Update is called once per frame

    private void Update()
    {
      if (Stopper.transform.rotation.eulerAngles.z >= 176)
        {
            name.enabled = true;
            this.enabled = false;
           
        }

        if (Stopper.transform.rotation.eulerAngles.z <= 3)
        {
            name.enabled = true;
            this.enabled = false;

        }
    }


    void FixedUpdate() {

        if (Input.GetKey("left"))
        {
            body.AddForce(new Vector2(-1, 1/20), ForceMode2D.Impulse);

        }

        if (Input.GetKey("right"))
        {
            body.AddForce(new Vector2(1, 1), ForceMode2D.Impulse);

        }

       

    }

   
}


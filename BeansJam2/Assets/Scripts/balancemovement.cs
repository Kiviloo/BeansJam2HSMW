
using UnityEngine;

public class balancemovement : MonoBehaviour {

    public Rigidbody2D body;
    public GameObject Stopper;
   
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame

    private void Update()
    {
      if (Stopper.transform.rotation.eulerAngles.z >= 177)
        {
            this.enabled = false;
           
        }

        if (Stopper.transform.rotation.eulerAngles.z <= 3)
        {
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


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject targetCamera;
    public Rigidbody physicsSystem;

    public float movementSpeed = 5.0f;
    public float jumpPower = 100.0f;

    bool onJumping = false;

    [SerializeField] private int Apple = 0;
    private int CurrentApple;
    [SerializeField] private TextMeshProUGUI CollectedApple;

    // Start is called before the first frame update
    void Start()
    {
        CurrentApple = Apple;
        CollectedApple.text = CurrentApple.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Update_Movement();
        Update_JumpMovement();
    }

    void Update_Movement()
    {
        Vector3 resultVelocity = new Vector3(0, physicsSystem.velocity.y, 0);

        if(Input.GetKey(KeyCode.W) == true)
        {
            resultVelocity += targetCamera.transform.forward * movementSpeed;
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            resultVelocity -= targetCamera.transform.forward * movementSpeed;
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            resultVelocity += targetCamera.transform.right * movementSpeed;
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            resultVelocity -= targetCamera.transform.right * movementSpeed;
        }

        resultVelocity = new Vector3(resultVelocity.x, physicsSystem.velocity.y, resultVelocity.z);
        physicsSystem.velocity = resultVelocity;
    }

    void Update_JumpMovement()
    {
        {
            if (Input.GetKeyDown(KeyCode.Space) == true && onJumping == false)
            {
                onJumping = true;
                physicsSystem.AddForce(new Vector3(0, jumpPower, 0));
            }
        }
    }

    private void OnCollisionEnter(Collision hitWithObject)
    {
        Vector3 playerPosition = gameObject.transform.position + new Vector3(0, 1, 0);
        Vector3 contactPoint = Get_CenterOfContactPoint(hitWithObject);

        if(playerPosition.y >= contactPoint.y)
        {
            onJumping = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Apple")
        {
            CurrentApple += 1;
        }
    }

    Vector3 Get_CenterOfContactPoint(Collision hitWithObject)
    {
        // Get Average Position of Contact Points. Sum them all and divide by how many of them.

        Vector3 centerOfContactPoint = new Vector3(0, 0, 0);
        ContactPoint[] contactPointList = new ContactPoint[hitWithObject.contactCount]; // Create an Array to keep all contact points.
        hitWithObject.GetContacts(contactPointList);    // Get All contact points and set it into contactPointList.

        for (int index = 0; index < contactPointList.Length; index += 1)
        {
            centerOfContactPoint += contactPointList[index].point; // Sum all contant points location together.
        }

        centerOfContactPoint = centerOfContactPoint / hitWithObject.contactCount; // Calculate Average of them to find center.

        return centerOfContactPoint;
    }
}

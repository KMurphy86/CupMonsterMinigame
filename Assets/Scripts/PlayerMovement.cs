using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform Spawner;
    public float speed = 16f; 
    public float turnSpeed = 16f;
    private float horizontalInput;
    private float forwardInput;
    public float xRange = 15;
    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //gets horizontal and vertical axis inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //player moves forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed *forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        //keeps player in certain x coordinate ranges
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //keeps player in certain z coordinate ranges
        if (transform.position.z < -23)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -23);
        }

        if (transform.position.z > -15)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -15);
        }
        // yay another "if" statement, its just to splat flavor blasts
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, Spawner.position, projectilePrefab.transform.rotation);
        }
    }

}

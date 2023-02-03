using UnityEditor.Rendering;
using UnityEngine;

public class Movements : MonoBehaviour
{
    public float speed = 1.0f;
    public float speedMouse = 1.0f;
    public float jumpForce = 1.0f;

    private Rigidbody Physics;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertiral = Input.GetAxis("Vertical");
        float constante = Time.deltaTime * speed;
        float constanteMouse = Time.deltaTime * speedMouse;
        transform.Translate(new Vector3(horizontal, 0.0f, vertiral) * constante);
        //rotation
        float rotationY = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, rotationY * constanteMouse));
        //Salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Physics.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }
}

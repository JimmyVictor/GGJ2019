using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

    [SerializeField] // shows up in inspector even if private
    private float speed = 1f;

    [SerializeField]
    private float lookSensitivity = 5f;


    private PlayerMotor motor;

    void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        // Calculate movement velocity as a 3D vector
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        Vector3 movHorizontal = transform.right * xMov;
        Vector3 movVertical = transform.forward * zMov;

        // Final movement vector
        Vector3 _velocity = (movHorizontal + movVertical).normalized * speed;

        // Apply movement
        motor.Move(_velocity);

        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        // Calculate rotation as a 3D vector (turning around)
        float yRot = Input.GetAxisRaw("Mouse X");

        Vector3 _rotation = new Vector3(0f, yRot, 0f) * lookSensitivity;

        //Apply rotation
        motor.Rotate(_rotation);

        // Calculate camera rotation as a 3D vector
        float xRot = Input.GetAxisRaw("Mouse Y");

        Vector3 _cameraRotation = new Vector3(xRot, 0f, 0f) * lookSensitivity;

        //Apply rotation
        motor.RotateCamera(_cameraRotation);
    }
}

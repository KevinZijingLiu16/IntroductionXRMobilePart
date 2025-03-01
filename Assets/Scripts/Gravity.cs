using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Gravity : MonoBehaviour
{
    private Accelerometer accelerometer;
    private float gravity = 9.81f;
    // An accelerometer let's you measure the acceleration of a device, and can be useful to control content by moving a device around.
    /// Note that the accelerometer will report the acceleration measured on a device both due to moving the device around, and due gravity
    /// pulling the device down. You can use <see cref="GravitySensor"/> and <see cref="LinearAccelerationSensor"/> to get decoupled values
    /// for these.
    [Header("UI")]
    [SerializeField] private TMP_Text debugTest;


    private void Start()
    {
        accelerometer = InputSystem.GetDevice<Accelerometer>(); // Get the accelerometer device
        if (accelerometer == null)
        {
            Debug.LogError("No accelerometer found");
            return;
        }
        else
        {
            InputSystem.EnableDevice(Accelerometer.current); // Enable the accelerometer
        }


    }

    private void Update()
    {
        if (accelerometer != null)
        {
            Vector2 deviceOrientation = accelerometer.acceleration.ReadValue(); // Get the device orientation from the accelerometer
            Physics2D.gravity = deviceOrientation * gravity; // Set the gravity to the device orientation * 9.81
            debugTest.text = ("Gravity:" + deviceOrientation * gravity); // Display the gravity on the screen
        }
    }
}

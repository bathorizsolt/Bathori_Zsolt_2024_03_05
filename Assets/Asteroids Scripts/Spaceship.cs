using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] float maxSpeed = 5;
    [SerializeField] float acceleration = 5;
    [SerializeField] float AngularSpeed = 180;

    Vector3 velocity;


    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        velocity += transform.up * acceleration * y * Time.deltaTime;
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

        //if (velocity.magnitude > maxSpeed)
        //{
        //    velocity = velocity.normalized * maxSpeed;
        //}
        // direction.Normalize();   
        


        /*
         * Vector3 step = Vector3.up;
         * step *= speed;
         * step *= Time.deltatime;
         */

        Vector3 step = velocity * Time.deltaTime;

        /*
        Vector2 position = transform.position;
        Vector2 newPosition = position + step;

        transform.position = newPosition;
        */

        transform.position += step;

        transform.Rotate(0,0, AngularSpeed * -x * Time.deltaTime);

        /* --- Forgatás ---
        if (direction != Vector3.zero)
        {

            float rotation2D = transform.rotation.eulerAngles.z; // 3D -> 2D
            float targetRotation = Vector2.SignedAngle(direction, Vector2.up);
            float nextRotation = Mathf.MoveTowardsAngle(rotation2D, targetRotation, Time.deltaTime * AngularSpeed);
            transform.rotation = Quaternion.Euler(0, 0, targetRotation); // 2D -> 3D
        }
        */
    }

}

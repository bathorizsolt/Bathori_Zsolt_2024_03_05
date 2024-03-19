using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] float speed = 5;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 direction = new(x, y);

        direction.Normalize();   
        


        /*
         * Vector3 step = Vector3.up;
         * step *= speed;
         * step *= Time.deltatime;
         */

        Vector3 step = direction * speed * Time.deltaTime;

        /*
        Vector2 position = transform.position;
        Vector2 newPosition = position + step;

        transform.position = newPosition;
        */

        transform.position += step;
    }

}

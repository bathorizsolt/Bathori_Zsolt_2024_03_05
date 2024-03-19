using UnityEngine;

public class VectorPractice : MonoBehaviour
{
    void Start()
    {
        Vector2 myVector = new(2, 3);

        Vector2 myOtherVector = new(4, 9);

        Vector2 summa = myVector + myOtherVector;
        //(6, 12)
        
        Vector2 diff = myVector - myOtherVector;
        //(-2, -6)

        Vector2 mult = diff * 5;
        //(-10, -30)

        Vector2 div = summa / 2;
        //(3, 6)

        float vectorLength = summa.magnitude; //vektor hossza
        //x

        Vector2 norm = summa.normalized;
        //x


    }
}

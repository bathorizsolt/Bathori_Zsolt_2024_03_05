using Unity.VisualScripting;
using UnityEngine;

public class MethodPractice : MonoBehaviour
{
    void Start()
    {
        Debug.Log("asd");
        MyFirstMethod(10,10);

        int max1 = Max(5, 8);
        int max2 = Max(23,11);
        int max3 = Max(30, 1);
    }

    int Max(int a, int b)
    {
        int max;
        if ( a > b )
            max = a;
        else
        max = b;
        
        return max;   
    }

    float AbsoluteValue(float i)
    {
        float abs;
        if ( i > 0)
            abs = i;
        else
            abs = -i;
        return abs;

        /*
        if ( i > 0)
            return i;
        else
            return -i;
         */
    }

    void MyFirstMethod(int rows, int coloumns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < coloumns; j++)
            {
                Debug.Log($"{i}*{j}={i * j}");
}        
}
    }
}

using UnityEngine;

public class BoolFunctions : MonoBehaviour
{
    void Start()
    {
        bool b1= true;
        bool b2= false;

        Debug.Log(b1);
        Debug.Log(b2);


        float a = 12, b = 33.5f;

        bool aIsHigherThanB = a > b; // False
        bool aIsLowerThanB = a < b; // True

        bool isEqual = a == b; //egyenlo-e -> false
        bool isNotEqual = a != b; ///nem egyenlo-e -> true

        a = 12; b = 12;

        aIsHigherThanB = a > b; //false
        aIsLowerThanB = a > b; //false

        bool aIsHigherThanBorEqual = a >= b; //true
        bool aIsLowerThanBorEqual = a <= b; //true

        bool equals1 = "nemlesz" == "nembizony"; //false
        bool equals2 = "nemlesz" == "nemlesz"; //true
        bool equals3 = "nemlesz" == "Nemlesz"; //false

        Debug.Log(equals1);
        Debug.Log(equals2);
        Debug.Log(equals3);


        //---------------------------------------------

        int ammo = 10;
        bool haveGun = true;
        bool haveAmmo = ammo > 0;

        bool canWeShoot = haveGun && haveAmmo;

        //--------------------------------------------

        bool isOnGround = false;
        bool canAirJump = true;

        bool canJump = isOnGround || canAirJump; // Altgr + W

        //--------------------------------------------

        bool isInTheAir = !isOnGround; // negalas

        //
    }
}

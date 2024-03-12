using UnityEngine;

public class MathFunctions : MonoBehaviour
{
    [SerializeField] float input1, input2;
    [SerializeField] float power, absolute, sign, rounded, ceiled, floored, min, max, sqrt; /*pow=hatvanyozas, abs=abszolutertek,
                                                                                            sign=elojel, rounded=kerekites, ceiled=legkozelebbi egesz, floored=legnagyobb egesz, 
                                                                                            min=legkisebb, bemenet, max=legnagyobb bemenet, sqrt=gyokvonas*/
    void OnValidate()
    {
        power = Mathf.Pow(input1, input2);
        absolute = Mathf.Abs(input1);
        sign = Mathf.Sign(input1);
        rounded = Mathf.Round(input1);
        ceiled = Mathf.Ceil(input1);
        floored = Mathf.Floor(input1);
        min = Mathf.Min(input1, input2);
        max = Mathf.Max(input1, input2);
        sqrt = Mathf.Sqrt(input1);



    }
}

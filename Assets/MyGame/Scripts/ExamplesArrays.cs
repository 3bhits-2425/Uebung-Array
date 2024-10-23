using UnityEngine;
using UnityEngine.UI;

public class ExamplesArrays : MonoBehaviour
{
    [SerializeField] GameObject[] arrayColoredImagesYellow; //Was für ein compile time Error wird angezeigt wenn dieser Array nicht
                                                            //über den Inspector initialisiert wird?

    void Start()
    {
        //Arrays
        //Deklaration eines Arrays vom Datentyp int
        int[] array; //Deklaration
        
        //Deklaration eines Arrays vom Datentyp  und GameObject
        int[] array1 = new int[4]; //mit 4 Elementen
        int[] array2 = new int[] {21,22,23,24};
        int[] array3 = { 31, 32, 33, 34, 35, 36, 37 }; //mit 7 Elementen
        GameObject[] arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");

        //Direkter Zugriff auf einzelne Elemente in einem Array
        //- Erstes Element im Array
        Debug.Log("Direkter Zugriff -------------------------------------Erstes Element");
        Debug.Log("Erstes Element im Array: an der Stelle mit Index 0: " + array1[0]);
        Debug.Log("Erstes Element im Array: an der Stelle mit Index 0: " + array2[0]);
        Debug.Log("Erstes Element im Array: an der Stelle mit Index 0: " + array3[0]);
        Debug.Log("Erstes Element im Array: an der Stelle mit Index 0: " + arrayColoredImagesRed[0].name);
        Debug.Log("Erstes Element im Array: an der Stelle mit Index 0: " + arrayColoredImagesYellow[0].gameObject.GetComponent<Image>().color);
        
        //- Letzes Element im Array: was passiert wenn man auf den Array mit array[array.Length] zugreift?
        Debug.Log("Direkter Zugriff -------------------------------------Letztes Element");
        Debug.Log("Letztes Element im Array: an der Stelle mit Index 0: " + array1[3]);
        Debug.Log("Letztes Element im Array: an der Stelle mit Index 0: " + array2[3]);
        Debug.Log("Letztes Element im Array: an der Stelle mit Index 0: " + array3[array3.Length-1]);
        int lastElemCIRed = arrayColoredImagesRed.Length -1; //Anzahl der Elemente im Array --> array.Length
        Debug.Log("Letztes Element im Array: an der Stelle mit Index 0: " + arrayColoredImagesRed[lastElemCIRed].name);
        int lastElemCIYellow = arrayColoredImagesYellow.Length -1;//Anzahl der Elemente im Array --> array.Length
        Debug.Log("Letztes Element im Array: an der Stelle mit Index 0: " + arrayColoredImagesYellow[lastElemCIYellow].gameObject.GetComponent<Image>().color);

        //Zugriff auf einen Array mittels For-Schleife. Eine For-Schleife führt eine Operation mehrmals aus.
        //Hier wird immer Wieder der Wert der Elemente als string im Array in einem Debug.Log ausgegeben. 
        //PrintArrayElementsAsOneString(array); //Auskommentiert, da compile-time error Warum?
        Debug.Log("Zugriff über For-Schleife -------------------------------------");
        PrintArrayElementsAsOneString(array1);
        PrintArrayElementsAsOneString(array2);
        PrintArrayElementsAsOneString(array3);
        PrintGameObjectName(arrayColoredImagesRed);
        PrintGameObjectName(arrayColoredImagesYellow);

        //Direkter Zugriff und neues Element zuweisen
        array3[1] = 31;
        Debug.Log("-----------Eine Zahl ändern");
        PrintArrayElementsAsOneString(array1);

        Debug.Log("-----------Alle Zahlen manuell im Script ändern");
        array3[0] = array3[1] = array3[2] = array3[3] = array3[4] = array3[5] = array3[6] = 300;
        PrintArrayElementsAsOneString(array3);

        
        for (int i = 0; i < array3.Length; i++)
        {
            array3[i] = 333;
        }
        Debug.Log("-----------Alle Zahlen ändern");
        PrintArrayElementsAsOneString(array3);
    }
    
    //Methode zur Ausgabe der Werte eines Array
    void PrintArrayElementsAsOneString(int[] paramArray)
    {
        string tmp = "";
        for (int i = 0; i < paramArray.Length; i++)
        {
            tmp += paramArray[i].ToString() + " ";
        }

        Debug.Log(tmp);
    }
    void PrintGameObjectName(GameObject[] paramGo)
    {
        for (int i = 0; i < paramGo.Length; i++)
        {
            Debug.Log(paramGo[i].name);
        }
    }
}

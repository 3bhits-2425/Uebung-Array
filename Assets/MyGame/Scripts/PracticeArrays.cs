using System;
using UnityEngine;
using UnityEngine.UI;

public class PracticeArrays : MonoBehaviour
{

    int[] testarray = null;

    //Array Deklaration & Initialisierung
    //-Deklarieren Sie einen Array mit namen array0
    int[] array0; //speichert int Werte
    
    //-Legen Sie einen Array mit Namen array1 vom Datentyp int mit 10 Elementen an
    int[] array1 = new int[10];
    
    //-Legen Sie einen Arraý vom Datentyp string mit Namen array2 mit 100 Elementen an und initialisieren Sie alle Elemente mit "testarray" 
    string[] array2 = new string[100];
    //Initialisierung siehe Aufruf in Methode Start und Deklaration von InitArray2()!

    //-Legen Sie ein Array vom Datentyp GameObject mit Namen array3 mit 10 Elementen an. Die GameObjects sollen Images sein mit dem Tag "test"
    [SerializeField]GameObject[] array3;

    int[] array4;

    //Gefordert ist ein Array mit Namen array4, dass mit allen geraden Zahlen zwischen 20 und 70 gefüllt ist. 
    //Gefordert ist ein Array mit Namen array5, dass 100 Elemente hält und als Elemente folgende Buchstabenreihe: "a", "b", "a", "b","a", "b","a", "b", ...
    //Gefordert ist ein Array mit Namen array6, dass alle geraden Zahlen zwischen 0 und 500 enthält.
    //Gefordert ist ein Array mit Namen array7, dass alle ungeraden Zahlen zwischen 0 und 500 enthält.
    //Gefordert ist ein Array mit Namen array8, dass alle geraden Zahlen zwischen 0 und 500 enthält.
    //Gefordert ist ein Array mit Namen array9, mit 1000 Elementen. Die Elemente werden mit Randomzahlen gefüllt und ausgegeben über Debug.
    //Das array9 einhält unsortierte int Werte. Sortiere das Array und gib mittels Debug.Log die Werte des sortierten array9 aus. 
    // - Hint: https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Array.html Methode Sort
    //Sortiere das Array array5 und gib es über Debug aus. 


    // Start is called before the first frame update

    void Start()
    {
        
        testarray = GenArray4(testarray);
        //@Legen Sie einen Arraý vom Datentyp string mit Namen array2 mit 100 Elementen an und initialisieren Sie alle Elemente mit "testarray" 
        InitArray2();

        //Array Zugriff
        //Greifen Sie auf das 4te Elemente in array1 zu und ändern sie den Wert auf 3. Geben Sie das Element mittels Debug.Log aus
        Debug.Log(array1[3]);
        
        //Greifen Sie auf das 33te Element in array2 zu und ändern sie den Wert auf "heute". Geben Sie das Element mittels Debug.Log aus
        array2[32] = "heute";
        Debug.Log(array2[32]);

        //Greifen Sie auf das 6te Element in array3 zu und ändern sie die Farbe auf grün. Die änderung sollte in der Scene/Game View ersichtlich sein 
        array3[5].gameObject.GetComponent<Image>().color = Color.green;
        //Zur weiteren Übung einfach Unterschiedliche Elemente ändern.

        //Array Zugiff erstes Element 
        //Greifen Sie auf das 1te Elemente in array1 zu und ändern sie den Wert auf 3. Geben Sie das Element mittels Debug.Log aus
        array1[0] = 3;
        Debug.Log(array1[0]);
        //Greifen Sie auf das 1te Element in array2 zu und ändern sie den Wert auf "heute". Geben Sie das Element mittels Debug.Log aus
        array2[0] = "heute";
        Debug.Log(array2[0]);

        //Greifen Sie auf das 1te Element in array3 zu und ändern sie die Farbe auf grün. Die Änderung sollte in der Scene/Game View ersichtlich sein 
        array3[0].gameObject.GetComponent<Image>().color = Color.green;

        //Gefordert ist ein Array mit Namen array4, dass mit allen geraden Zahlen zwischen 20 und 70 gefüllt ist. 
        array4 = GenArray4(array4);
        //PrintArray(array4);

        //Gefordert ist ein Array mit Namen array5, dass alle geraden Zahlen zwischen 0 und 500 enthält.
        int[] array5 = null; 
        array5 = GenArray5(array5);

        //Gefordert ist ein Array mit Namen array6, dass alle ungeraden Zahlen zwischen 0 und 500 enthält.
        int[] array6 = null;
        array6 = GenArray6(array6);

        //Gefordert ist ein Array mit Namen array7, dass 100 Elemente hält und als Elemente folgende Buchstabenreihe: "a", "b", "a", "b","a", "b","a", "b", ...
        //array5 als lokale variable deklariert in start definiert. 
        string[] array7 = new string[100];
        array7 = GenArray7(array7);
        //PrintArray(array7);

        //Gefordert ist ein Array mit Namen array9, mit 1000 Elementen. 
        //Die Elemente werden mit Randomzahlen gefüllt und ausgegeben über Debug.
        int[] array9 = new int[1000];
        array9 = GenArray9(array9);
        Debug.Log("***************************************** Randomized array before Sort");
       // PrintArray(array9);

        //Das array9 einhält unsortierte int Werte. Sortiere das Array und gib mittels Debug.Log die Werte des sortierten array9 aus. 
        //Hier wird System.Array verwendet!!
        // - Hint: https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Array.html Methode Sort
        Array.Sort(array9);
        Debug.Log("***************************************** Randomized array after Sort" );
        //PrintArray(array9);

        //Kopiere array5 und arry6 in ein neues array10
        int[] array10 = new int[array6.Length + array5.Length];
        array10 = GenArray10V1(array10, array5, array6);
        Debug.Log("***************************************** Copy Array");
        PrintArray(array10);

        int[] array11 = new int[array6.Length + array5.Length];
        array11 = GenArray11(array11, array5, array6);
        PrintArray(array11);

    }

    private int[] GenArray10V1(int[] destinationArray, int[] arrayToCopy1, int[] arrayToCopy2)
    {
        for (int i = 0; i < arrayToCopy1.Length; i++)
        {
            destinationArray[i] = arrayToCopy1[i];
        }

        int j = 0;
        for (int i = arrayToCopy1.Length; i < destinationArray.Length; i++)
        {
            destinationArray[i] = arrayToCopy2[j];
            j++;
        }
        return destinationArray;
    }

    int[] GenArray11(int[] destinationArray, int[] arrayToCopy1, int[] arrayToCopy2)
    {
        arrayToCopy1.CopyTo(destinationArray,0);
        arrayToCopy2.CopyTo(destinationArray, arrayToCopy1.Length);
        return destinationArray;
    }

    private void InitArray2()
    {
        for(int i = 0; i < array2.Length; i++)
        {
            array2[i] = "testarray";
        }
    }

    int[] GenArray4(int[] a)
    {
        a = new int[EvaluateArrayLenthEvenNumbers(20,70)];
        
        int index = 0;
        for (int i = 20; i <= 70; i++)
        {
            if(i%2 == 0)
            {
                a[index] = i;
                index++;
            }
        }

        return a;
    }

    int[] GenArray5(int[] a)
    {
        a = new int[EvaluateArrayLenthEvenNumbers(0,500)];

        int index = 0;
        for (int i = 0; i <= 500; i++)
        {
            if (i % 2 == 0)
            {
                a[index] = i;
                index++;
                Debug.Log("--------------------------------------- " +i);
            }
        }

        return a;
    }

    int[] GenArray6(int[] a)
    {
        a = new int[EvaluateArrayLenthOddNumbers(0, 500)];

        int index = 0;
        for (int i = 0; i <= 500; i++)
        {
            if (i % 2 != 0)
            {
                a[index] = i;
                index++;
            }
        }

        return a;
    }

    string[] GenArray7(string[] a)
    {
        for (int i = 0; i < 100; i++)
        {
            if(i%2 == 0)
            {
                a[i] = "a";
            }
            else
            {
                a[i] = "b";
            }
        }
        return a;
    }

    int[] GenArray9(int[] a)
    {
        for(int i = 0; i < a.Length; i++)
        {
            a[i] = (int)UnityEngine.Random.Range(0f, 1000f);
        }
        return a;
    }

    int EvaluateArrayLenthEvenNumbers(int min, int max)
    {
        int numberEvenNumbers = 0;
        for (int i = min; i <= max; i++)
        {
            if (i % 2 == 0)
            {
                numberEvenNumbers++;
            }
        }
        Debug.Log("--------------------------------- quantityEvenNumber"+numberEvenNumbers);
        return numberEvenNumbers;
    }

    int EvaluateArrayLenthOddNumbers(int min, int max)
    {
        int quantityOddNumbers = 0;
        for (int i = min; i <= max; i++)
        {
            if (i % 2 != 0)
            {
                quantityOddNumbers++;
            }
        }
        return quantityOddNumbers;
    }

    void PrintArray(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Debug.Log("Element ["+i+"] = " + a[i]);
        }
    }

    void PrintArray(string[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Debug.Log("Element [" + i + "] = " + a[i]);
        }
    }

}

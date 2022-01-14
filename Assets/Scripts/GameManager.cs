using UnityEngine;  
public class GameManager : MonoBehaviour
{
    public Variant variant;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void compare(selera temp, selera temp2, selera temp3)
    {
        // K1
        if (temp == selera.Family && temp2 == selera.Animation)
        {
            Debug.Log("k1");
            ScoreGameplay.value += 20;
            
        }
        // K3
        else if (temp == selera.Romance && temp2 == selera.Musikal && temp3 == selera.Fantasy)
        {
            Debug.Log("k3");
            ScoreGameplay.value += 20;
        }
        // k4
        else if (temp == selera.War && temp2 == selera.Action && temp3 == selera.Adventure)
        {
            Debug.Log("k4");
            ScoreGameplay.value += 20;
        }
        // k5
        else if (temp == selera.Horror && temp2 == selera.Romance && temp3 == selera.Comedy)
        {
            Debug.Log("k5");
            ScoreGameplay.value += 20;

        }
        // k6
        else if (temp == selera.Romance && temp2 == selera.Thriller && temp3 == selera.Mystery)
        {
            Debug.Log("k6");
            ScoreGameplay.value += 20;
        }
        // K7
        else if (temp == selera.Family && temp2 == selera.Animation && temp3 == selera.Crime)
        {
            Debug.Log("k7");
            ScoreGameplay.value += 20;
        }
        // K8
        else if (temp == selera.Drama && temp2 == selera.Biography)
        {
            Debug.Log("k8");
            ScoreGameplay.value += 20;
        }
        // K9
        else if (temp == selera.Historical && temp2 == selera.Western)
        {
            Debug.Log("k9");
            ScoreGameplay.value += 20;
        }
        // S1
        else if (temp == selera.Scifi && temp2 == selera.Fantasy)
        {
            Debug.Log("s1");
            ScoreGameplay.value += 30;
        }
        // S2
        else if (temp == selera.Music && temp2 == selera.Musikal)
        {
            Debug.Log("s2");
            ScoreGameplay.value += 30;
        }
        // S3
        else if (temp == selera.Sport)
        {
            Debug.Log("s3");
            ScoreGameplay.value += 30;
        }
        else
        {
            ScoreGameplay.value += 0;
            Debug.Log(":(");
        }
    }


    public void comparison()
    {
        compare(variant.seleraType[0], variant.seleraType[1], variant.seleraType[2]);
        Debug.Log("yeyy");  
    }

    public enum selera
    {
        Family,
        Animation,
        Romance,
        Musikal,
        Fantasy,
        War,
        Action,
        Adventure,
        Horror,
        Comedy,
        Thriller,
        Mystery,
        Crime,
        Drama,
        Biography,
        Historical,
        Western,
        Scifi,
        Music,
        Sport
    }
}

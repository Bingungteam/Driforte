using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonText : MonoBehaviour
{
    public Text MasukanJudul;
    private int index;
    public Dropdown drop;

    public void addit()
    {
        drop.options.Add(new Dropdown.OptionData(){text = MasukanJudul.text });
        drop.RefreshShownValue();
    }

    
    public void deleteit()
    {
        drop.options.RemoveAt(index);
        drop.RefreshShownValue();
    }

    public void setIndex(int varIndex)
    {
        this.index = varIndex;
    }

  

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

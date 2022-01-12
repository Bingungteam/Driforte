using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class infotempat_tmp : MonoBehaviour
{
    public TextMeshProUGUI desc;
    public TextMeshProUGUI info;

    // Start is called before the first frame update
    void Start()
    {
        desc.text = "Terkenal akan pantai-pantai diujung kota dan buah-buahan tropis yang dimilikinya sehingga dijuluki sebagai kota “Sunshine Paradise”, Confuso memang sangat identik dengan liburan khas musim panas. Namun, tidak hanya itu saja kota Confuso tak hanya menyimpan pantai dan buah-buahan tropis saja, tetapi ada juga terdapat banyak hidden gems berupa destinasi wisata yang unik dan menarik yang terletak pada pusat kota yang depenuhi oleh gedung-gedung pencakar langit.";
        info.text = "City Info :";
    }
}

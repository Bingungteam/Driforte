using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingProgress : MonoBehaviour
{
    public void Memulai()
    {
        // Disini bisa mengatur scene mana yang mau kita targetkan.
        // Namun harus menuliskan nama scene yang dituju.
        Application.LoadLevel("ShopFeature");
    }

    // Fungsi script ini terpasang di animasi loading fill.
}

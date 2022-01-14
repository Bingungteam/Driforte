using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class iklan : MonoBehaviour
{
    public TextMeshProUGUI kategori;
    public TextMeshProUGUI penjelasan;

    public bool pilihan;
    public GameObject gambar1;
    public GameObject gambar2;
    public GameObject gambar3;
    public GameObject gambar4;
    public GameObject gambar5;

    public void aturiklan(int nilai_objek)
    {
        if(nilai_objek >= 1)
        {
            gambar1.SetActive(pilihan);
            gambar2.SetActive(false);
            gambar3.SetActive(false);
            gambar4.SetActive(false);
            gambar5.SetActive(false);

            kategori.text = "Brosure";
            penjelasan.text = "Dengan menggunakan brosur kita dapat menawarkan suatu produk dengan informasi yang menarik pada masyarakat. Biasanya dalam bentuk selebaran kertas yang memuat informasi singkat mengenai bioskop kami yang menarik. mendapatkan 20 penonton setiap harinya.";
        }
        if(nilai_objek >= 2)
        {
            gambar1.SetActive(false);
            gambar2.SetActive(pilihan);
            gambar3.SetActive(false);
            gambar4.SetActive(false);
            gambar5.SetActive(false);
            
            kategori.text = "Koran ";
            penjelasan.text = "Dengan menggunakan koran kita dapat memberikan informasi ataupun berita-berita terkini yang ada disekitar kita. Dengan koran kami bisa mengiklankan bioskop kami dengan berita terupdate setiap harinya. mendapatkan efek promosi berupa 5 penonton tambahan.";
        }
        if(nilai_objek >= 3)
        {
            gambar1.SetActive(false);
            gambar2.SetActive(false);
            gambar3.SetActive(pilihan);
            gambar4.SetActive(false);
            gambar5.SetActive(false);

            kategori.text = "Website";
            penjelasan.text = "Dengan menggunakan website, kami dapat mengiklankan bioskop kami menggunakan website pribadi, sehingga kami dapat mempromosikannya secara online dan digital. mendapatkan efek promosi berupa 5 penonton tambahan.";
        }
        if(nilai_objek >= 4)
        {
            gambar1.SetActive(false);
            gambar2.SetActive(false);
            gambar3.SetActive(false);
            gambar4.SetActive(pilihan);
            gambar5.SetActive(false);

            kategori.text = "Televisi";
            penjelasan.text = "Dengan menggunakan televisi kami dapat menampilkan iklan menggunakan media tersebut,iklan televisi sangat menarik bagi masyarakat karna dapat menggabungkan suara, gambar dan gerak untuk iklan mengenai bioskop kami. mendapatkan efek promosi berupa 10 penonton tambahan.";
        }
        if(nilai_objek >= 5)
        {
            gambar1.SetActive(false);
            gambar2.SetActive(false);
            gambar3.SetActive(false);
            gambar4.SetActive(false);
            gambar5.SetActive(pilihan);

            kategori.text = "Billboard";
            penjelasan.text = "Dengan menggunakan billboard  kami dapat mengiklankan bioskop kami pada titik-titik strategis yang ada di setiap jalan, karena billboard memiliki ukuran yang besar dan dapat diletakkan pada tempat yang tinggi sehingga banyak orang melintas dapat melihat iklan tersebut. Sehingga memudahkan masyarakat dalam mengenali bioskop kami. mendapatkan efek promosi berupa 10 penonton tambahan.";
        }

    }
}

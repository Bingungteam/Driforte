using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{

    public int[,] shopItems = new int[60, 60];
    public TextMeshProUGUI coinText;


    void Start()
    {
        coinText.text = PlayerPrefsManager.instance.GetCoins().ToString();

        //ID's
        shopItems[1, 1] = 1; //popcorn
        shopItems[1, 2] = 2; //soda
        shopItems[1, 3] = 3; //popcorn caramel
        shopItems[1, 4] = 4; //ice lemon tea
        shopItems[1, 5] = 5; //popcorn milk butter
        shopItems[1, 6] = 6; //ice cappucino
        shopItems[1, 7] = 7;  //tiket
        shopItems[1, 8] = 8; //film action 1
        shopItems[1, 9] = 9; //film action 2
        shopItems[1, 10] = 10; //film adventure 1
        shopItems[1, 11] = 11; //film adventure 2
        shopItems[1, 12] = 12; //film animation 1
        shopItems[1, 13] = 13; //film animation 2
        shopItems[1, 14] = 14; //film biography 1
        shopItems[1, 15] = 15; //film biography 2
        shopItems[1, 16] = 16; //film comedy 1
        shopItems[1, 17] = 17; //film comedy 2
        shopItems[1, 18] = 18; //film crime 1
        shopItems[1, 19] = 19; //film crime 1
        shopItems[1, 20] = 20; //film drama 1
        shopItems[1, 21] = 21; //film drama 2
        shopItems[1, 22] = 22; //film drama 3
        shopItems[1, 23] = 23; //film drama 4
        shopItems[1, 24] = 24; //film family 1
        shopItems[1, 25] = 25; //film family 2
        shopItems[1, 26] = 26; //film fantasy 1
        shopItems[1, 27] = 27; //film fantasy 2
        shopItems[1, 28] = 28; //film history 1
        shopItems[1, 29] = 29; //film history 2
        shopItems[1, 30] = 30; //film horror 1
        shopItems[1, 31] = 31; //film horror 2
        shopItems[1, 32] = 32; //film music 1
        shopItems[1, 33] = 33; //film music 2
        shopItems[1, 34] = 34; //film musical 1
        shopItems[1, 35] = 35; //film musical 2
        shopItems[1, 36] = 36; //film mystery 1
        shopItems[1, 36] = 37; //film mystery 2
        shopItems[1, 37] = 38; //film romance 1
        shopItems[1, 38] = 39; //film romance 2
        shopItems[1, 39] = 40; //film scifi 1
        shopItems[1, 40] = 41; //film scifi 2
        shopItems[1, 41] = 42; //film sport 1
        shopItems[1, 42] = 43; //film sport 2
        shopItems[1, 43] = 44; //film thriller 1
        shopItems[1, 44] = 45; //film thriller 2
        shopItems[1, 45] = 46; //film war 1
        shopItems[1, 46] = 47; //film war 2
        shopItems[1, 47] = 48; //film western 1
        shopItems[1, 48] = 49; //film western 2

            // Strategy Shop
            shopItems[1, 20] = 20; // Upgrade snackbar level 2
            shopItems[1, 21] = 21; // Upgrade snackbar level 3
            shopItems[1, 22] = 22; // Upgrade studio level 2
            shopItems[1, 23] = 23; // Upgrade studio level 3
            shopItems[1, 24] = 24; // Upgrade Building level 2
            shopItems[1, 25] = 25; // Upgrade Building level 3

        //Price
        shopItems[2, 1] = 50;
        shopItems[2, 2] = 30;
        shopItems[2, 3] = 70;
        shopItems[2, 4] = 40;
        shopItems[2, 5] = 110;
        shopItems[2, 6] = 70;
        shopItems[2, 7] = 50;
        shopItems[2, 8] = 1000; //film action 1
        shopItems[2, 9] = 1000; //film action 2
        shopItems[2, 10] = 1000; //film adventure 1
        shopItems[2, 11] = 1000; //film adventure 2
        shopItems[2, 12] = 1000; //film animation 1
        shopItems[2, 13] = 1000; //film animation 2
        shopItems[2, 14] = 1000; //film biography 1
        shopItems[2, 15] = 1000; //film biography 2
        shopItems[2, 16] = 1000; //film comedy 1
        shopItems[2, 17] = 1000; //film comedy 2
        shopItems[2, 18] = 1000; //film crime 1
        shopItems[2, 19] = 1000; //film crime 1
        shopItems[2, 20] = 1000; //film drama 1
        shopItems[2, 21] = 1000; //film drama 2
        shopItems[2, 22] = 1000; //film drama 3
        shopItems[2, 23] = 1000; //film drama 4
        shopItems[2, 24] = 1000; //film family 1
        shopItems[2, 25] = 1000; //film family 2
        shopItems[2, 26] = 2000; //film fantasy 1
        shopItems[2, 27] = 2000; //film fantasy 2
        shopItems[2, 28] = 1000; //film history 1
        shopItems[2, 29] = 1000; //film history 2
        shopItems[2, 30] = 1000; //film horror 1
        shopItems[2, 31] = 1000; //film horror 2
        shopItems[2, 32] = 2000; //film music 1
        shopItems[2, 33] = 2000; //film music 2
        shopItems[2, 34] = 2000; //film musical 1
        shopItems[2, 35] = 2000; //film musical 2
        shopItems[2, 36] = 1000; //film mystery 1
        shopItems[2, 37] = 1000; //film mystery 2
        shopItems[2, 38] = 1000; //film romance 1
        shopItems[2, 39] = 1000; //film romance 2
        shopItems[2, 40] = 2000; //film scifi 1
        shopItems[2, 41] = 2000; //film scifi 2
        shopItems[2, 42] = 2000; //film sport 1
        shopItems[2, 43] = 2000; //film sport 2
        shopItems[2, 44] = 1000; //film thriller 1
        shopItems[2, 45] = 1000; //film thriller 2
        shopItems[2, 46] = 1000; //film war 1
        shopItems[2, 47] = 1000; //film war 2
        shopItems[2, 48] = 1000; //film western 1
        shopItems[2, 49] = 1000; //film western 2

            // Strategy Shop
            shopItems[2, 20] = 6000; // Upgrade snackbar level 2
            shopItems[2, 21] = 8000; // Upgrade snackbar level 3
            shopItems[2, 22] = 12000; // Upgrade studio level 2
            shopItems[2, 23] = 14000; // Upgrade studio level 3
            shopItems[2, 24] = 8000; // Upgrade Building level 2
            shopItems[2, 25] = 10000; // Upgrade Building level 3

        //Quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;
        shopItems[3, 5] = 0;
        shopItems[3, 6] = 0;
        shopItems[3, 7] = 0;
        shopItems[3, 8] = 0; //film action 1
        shopItems[3, 9] = 0; //film action 2
        shopItems[3, 10] = 0; //film adventure 1
        shopItems[3, 11] = 0; //film adventure 2
        shopItems[3, 12] = 0; //film animation 1
        shopItems[3, 13] = 0; //film animation 2
        shopItems[3, 14] = 0; //film biography 1
        shopItems[3, 15] = 0; //film biography 2
        shopItems[3, 16] = 0; //film comedy 1
        shopItems[3, 17] = 0; //film comedy 2
        shopItems[3, 18] = 0; //film crime 1
        shopItems[3, 19] = 0; //film crime 1
        shopItems[3, 20] = 0; //film drama 1
        shopItems[3, 21] = 0; //film drama 2
        shopItems[3, 22] = 0; //film drama 3
        shopItems[3, 23] = 0; //film drama 4
        shopItems[3, 24] = 0; //film family 1
        shopItems[3, 25] = 0; //film family 2
        shopItems[3, 26] = 0; //film fantasy 1
        shopItems[3, 27] = 0; //film fantasy 2
        shopItems[3, 28] = 0; //film history 1
        shopItems[3, 29] = 0; //film history 2
        shopItems[3, 30] = 0; //film horror 1
        shopItems[3, 31] = 0; //film horror 2
        shopItems[3, 32] = 0; //film music 1
        shopItems[3, 33] = 0; //film music 2
        shopItems[3, 34] = 0; //film musical 1
        shopItems[3, 35] = 0; //film musical 2
        shopItems[3, 36] = 0; //film mystery 1
        shopItems[1, 37] = 0; //film mystery 2
        shopItems[3, 38] = 0; //film romance 1
        shopItems[3, 39] = 0; //film romance 2
        shopItems[3, 40] = 0; //film scifi 1
        shopItems[3, 41] = 0; //film scifi 2
        shopItems[3, 42] = 0; //film sport 1
        shopItems[3, 43] = 0; //film sport 2
        shopItems[3, 44] = 0; //film thriller 1
        shopItems[3, 45] = 0; //film thriller 2
        shopItems[3, 46] = 0; //film war 1
        shopItems[3, 47] = 0; //film war 2
        shopItems[3, 48] = 0; //film western 1
        shopItems[3, 49] = 0; //film western 2

            // Strategy Shop
            shopItems[1, 20] = 20; // Upgrade snackbar level 2
            shopItems[1, 21] = 21; // Upgrade snackbar level 3
            shopItems[1, 22] = 22; // Upgrade studio level 2
            shopItems[1, 23] = 23; // Upgrade studio level 3
            shopItems[1, 24] = 24; // Upgrade Building level 2
            shopItems[1, 25] = 25; // Upgrade Building level 3
    }


    private void Update()
    {
        // Update nilai coin
        coinText.text = PlayerPrefsManager.instance.GetCoins().ToString();
    }

    private void Transaction()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        // coin saat ini dikurang harga coin
        PlayerPrefsManager.instance.SetCoins(PlayerPrefsManager.instance.GetCoins() - shopItems[2, ButtonRef.GetComponent<ButtonInfo>().itemId]);

        // simpan dan | ambil dan tambahkan kuantitas item dengan id
        PlayerPrefsManager.instance.SetQuantityItemsWithId(ButtonRef.GetComponent<ButtonInfo>().itemId, PlayerPrefsManager.instance.GetQuantityItemsWithId(ButtonRef.GetComponent<ButtonInfo>().itemId) + 1);

        // tampilkan kuantitas terbaru
        ButtonRef.GetComponent<ButtonInfo>().quantityTxt.text = PlayerPrefsManager.instance.GetQuantityItemsWithId(ButtonRef.GetComponent<ButtonInfo>().itemId).ToString();
    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (PlayerPrefsManager.instance.GetCoins() >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().itemId])
        {
            Transaction();
        }
    }

    public void BuyOnceAtZeroQty()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (PlayerPrefsManager.instance.GetQuantityItemsWithId(ButtonRef.GetComponent<ButtonInfo>().itemId) == 0)
        {
            if (PlayerPrefsManager.instance.GetCoins() >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().itemId])
            {
                Transaction();
            }
        }

    }

    public void BuyOnceOnly()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (PlayerPrefsManager.instance.GetBuyOnceOnlyWithId(ButtonRef.GetComponent<ButtonInfo>().itemId) == 0)
        {
            if (PlayerPrefsManager.instance.GetCoins() >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().itemId])
            {
                Transaction();
                // set buy only once
                PlayerPrefsManager.instance.SetBuyOnceOnlyWithId(ButtonRef.GetComponent<ButtonInfo>().itemId, 1);
            }
        }

    }

    public void UseItem()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (PlayerPrefsManager.instance.GetQuantityItemsWithId(ButtonRef.GetComponent<ButtonInfo>().itemId) > 0)
        {
            // kurangi kuantitas
            PlayerPrefsManager.instance.SetQuantityItemsWithId(ButtonRef.GetComponent<ButtonInfo>().itemId, PlayerPrefsManager.instance.GetQuantityItemsWithId(ButtonRef.GetComponent<ButtonInfo>().itemId) - 1);

            // tampilkan kuantitas terbaru
            ButtonRef.GetComponent<ButtonInfo>().quantityTxt.text = PlayerPrefsManager.instance.GetQuantityItemsWithId(ButtonRef.GetComponent<ButtonInfo>().itemId).ToString();
        }
    }
}


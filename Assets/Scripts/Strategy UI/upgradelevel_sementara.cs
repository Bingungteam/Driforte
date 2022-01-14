using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgradelevel_sementara : MonoBehaviour
{
    public GameObject Level1;
    public Image level2;
    public Image level3;
    public bool pilihan;

    public void upgradebuildlevel2() {
        level2.IsInvoking();
    }

    public void upgradebuildlevel3() {
        level3.IsInvoking();
    }
}

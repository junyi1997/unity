using UnityEngine;
using System.Collections;
using System.Threading;

public class control : MonoBehaviour
{
    public GameObject cam1, cam2;
    bool a =true,b=false;

    /* 放在Awake內，在物件執行之前就先封鎖住，避免物件的出現，直到使用者切換攝影機後再創造該物件，若是放在Start內則會造成全部的物件都已經產生且初始化後再封鎖住。 */
    void Awake()
    {
        //預設先開啟第一部攝影機

        //一定要先暫停不使用的攝影機後，再開啟要使用的攝影機！
        cam2.SetActive(false);
        cam1.SetActive(true);

    }

    void Update()
    {
        if (Input.GetKey("z") == true)
        {
            Thread.Sleep(100);
            if (a == true)
            {

                cam1.SetActive(false);
                cam2.SetActive(true);
                a = false; b = true;
            }
            else if (b == true)
            {

                cam2.SetActive(false);
                cam1.SetActive(true);
                b = false; a = true;
            }

        }
    }
}

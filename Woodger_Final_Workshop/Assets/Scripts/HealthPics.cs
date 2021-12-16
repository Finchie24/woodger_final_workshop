using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPics : MonoBehaviour
{
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public GameObject Heart4;
    public GameObject Heart5;
    public GameObject Heart6;
    public GameObject Heart7;
    public GameObject Heart8;
    public GameObject Heart9;
    public GameObject Heart10;

    void Start()
    {
        Heart1.SetActive(true);
        Heart2.SetActive(false);
        Heart3.SetActive(false);
        Heart4.SetActive(false);
        Heart5.SetActive(false);
        Heart6.SetActive(false);
        Heart7.SetActive(false);
        Heart8.SetActive(false);
        Heart9.SetActive(false);
        Heart10.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (StartingStats.health == 10)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
            Heart4.SetActive(true);
            Heart5.SetActive(true);
            Heart6.SetActive(true);
            Heart7.SetActive(true);
            Heart8.SetActive(true);
            Heart9.SetActive(true);
            Heart10.SetActive(true);
        }
        if (StartingStats.health == 9)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
            Heart4.SetActive(true);
            Heart5.SetActive(true);
            Heart6.SetActive(true);
            Heart7.SetActive(true);
            Heart8.SetActive(true);
            Heart9.SetActive(true);
            Heart10.SetActive(false);
        }
        if (StartingStats.health == 8)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
            Heart4.SetActive(true);
            Heart5.SetActive(true);
            Heart6.SetActive(true);
            Heart7.SetActive(true);
            Heart8.SetActive(true);
            Heart9.SetActive(false);
            Heart10.SetActive(false);
        }
        if (StartingStats.health == 7)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
            Heart4.SetActive(true);
            Heart5.SetActive(true);
            Heart6.SetActive(true);
            Heart7.SetActive(true);
            Heart8.SetActive(false);
            Heart9.SetActive(false);
            Heart10.SetActive(false);
        }
        if (StartingStats.health == 6)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
            Heart4.SetActive(true);
            Heart5.SetActive(true);
            Heart6.SetActive(true);
            Heart7.SetActive(false);
            Heart8.SetActive(false);
            Heart9.SetActive(false);
            Heart10.SetActive(false);
        }
        if (StartingStats.health == 5)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
            Heart4.SetActive(true);
            Heart5.SetActive(true);
            Heart6.SetActive(false);
            Heart7.SetActive(false);
            Heart8.SetActive(false);
            Heart9.SetActive(false);
            Heart10.SetActive(false);
        }
        if (StartingStats.health == 4)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
            Heart4.SetActive(true);
            Heart5.SetActive(false);
            Heart6.SetActive(false);
            Heart7.SetActive(false);
            Heart8.SetActive(false);
            Heart9.SetActive(false);
            Heart10.SetActive(false);
        }
        if (StartingStats.health == 3)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
            Heart4.SetActive(false);
            Heart5.SetActive(false);
            Heart6.SetActive(false);
            Heart7.SetActive(false);
            Heart8.SetActive(false);
            Heart9.SetActive(false);
            Heart10.SetActive(false);
        }
        if (StartingStats.health == 2)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(false);
            Heart4.SetActive(false);
            Heart5.SetActive(false);
            Heart6.SetActive(false);
            Heart7.SetActive(false);
            Heart8.SetActive(false);
            Heart9.SetActive(false);
            Heart10.SetActive(false);
        }
        if (StartingStats.health == 1)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(false);
            Heart3.SetActive(false);
            Heart4.SetActive(false);
            Heart5.SetActive(false);
            Heart6.SetActive(false);
            Heart7.SetActive(false);
            Heart8.SetActive(false);
            Heart9.SetActive(false);
            Heart10.SetActive(false);
        }
        if (StartingStats.health == 0)
        {
            Heart1.SetActive(false);
            Heart2.SetActive(false);
            Heart3.SetActive(false);
            Heart4.SetActive(false);
            Heart5.SetActive(false);
            Heart6.SetActive(false);
            Heart7.SetActive(false);
            Heart8.SetActive(false);
            Heart9.SetActive(false);
            Heart10.SetActive(false);
        }
    }
}

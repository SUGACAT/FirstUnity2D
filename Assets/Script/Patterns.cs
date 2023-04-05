using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

enum PatternNumber
{
    horizontal,
    vertical,
    circle,
}

public class Patterns : MonoBehaviour
{
    public float nextPatternTime;

    public GameObject[] attackBox;
    public bool boxCanDisable = false;

    public bool pattern1Active = false;
    public bool pattern2Active = false;
    public bool pattern3Active = false;

    public Dictionary<int, bool> progressDic = new Dictionary<int, bool>();

    PatternNumber patternNum = new PatternNumber();

    delegate void PatternMethods();

    // Start is called before the first frame update
    void Start()
    {
        progressDic.Add(0, pattern1Active);
        progressDic.Add(1, pattern2Active);
        progressDic.Add(2, pattern3Active);

        int random = Random.Range(0, System.Enum.GetValues(typeof(PatternNumber)).Length);

        progressDic[random] = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Pattern1()
    {
        int random = Random.Range(0, 3);
    }

    IEnumerator boxSpawnCoroutine(int value)
    {
        yield return new WaitUntil(() => boxCanDisable);
    }

}

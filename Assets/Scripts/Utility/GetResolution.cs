using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetResolution : MonoBehaviour
{
    // Start is called before the first frame update
    private Resolution[] res;
    private List<string> resOpt;
    private TMP_Dropdown dd;
    void Start()
    {
        dd = GetComponent<TMP_Dropdown>();
        dd.ClearOptions();
        res = Screen.resolutions;
        resOpt = new List<string>();
        for (int i=0;i< res.Length; i++)
        {
            resOpt.Add(res[i].ToString());
        }
        dd.AddOptions(resOpt);

        for(int i = 0; i < res.Length; i++)
        {
            if (resOpt[i] == Screen.currentResolution.ToString())
            {
                dd.value = i;
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetRsolution()
    {
        //dd.value
        Screen.SetResolution(res[dd.value].width, res[dd.value].height, false);
        
    }
}

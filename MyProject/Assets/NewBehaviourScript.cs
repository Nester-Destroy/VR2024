using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Networking;
using UnityEngine.EventSystems;
public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Test;
    public Text Mytext;
    public int x = 0;
    // Start is called before the first frame update
    void Start1()
    {
        Mytext.text = x.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void ClickBut() {
        Test.SetActive(false);
    }
    public void OnCollisionEnter(Collision collision)
    {
        x+=1;
        Mytext.text = x.ToString();
        if (x==3)
            Test.SetActive(false);
    }
}

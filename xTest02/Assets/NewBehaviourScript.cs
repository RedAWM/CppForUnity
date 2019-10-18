using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using AOT;

public class NewBehaviourScript : MonoBehaviour {

    [DllImport("CppNet100")]
    private static extern int Add(int a, int b);

    public delegate void CallBack1(string s);

    [DllImport("CppNet100")]
    private static extern void TestCall1(string s, CallBack1 cb);

    [MonoPInvokeCallback(typeof(CallBack1))]
    public void CallBackFun1(string s)
    {
        Debug.Log(s);
    }

    // Use this for initialization
    void Start () {
        Debug.Log(Add(4,5));
        TestCall1("Hei Hei", CallBackFun1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

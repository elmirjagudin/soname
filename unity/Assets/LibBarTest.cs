using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class LibBarTest : MonoBehaviour
{
    [DllImport("bar")]
    static extern int bar(int x);

	void Start()
    {
        Debug.LogFormat("x = {0}", bar(10));
	}
}

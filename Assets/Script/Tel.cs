using UnityEngine;
using System.Collections;
using System;
using SLua;

[CustomLuaClass]
public class Tel
{

    public static void CallTel(string tel)
    {
        Application.OpenURL("tel:" + tel);
    }

}
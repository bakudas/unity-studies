using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMemberClass : MemberClass
{
    new public void Yell()
    {
        Debug.Log("BBBBBBBBBBBBBBBBBBBB");
    }
}

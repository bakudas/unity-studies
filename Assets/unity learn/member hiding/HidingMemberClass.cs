using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingMemberClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MemberClass memberClass = new MemberClass();
        memberClass.Yell();
        HideMemberClass hideMemberClass = new HideMemberClass();
        hideMemberClass.Yell();   
    }
}

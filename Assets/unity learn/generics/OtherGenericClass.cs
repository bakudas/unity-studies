using UnityEngine;

namespace unity_learn.generics
{
    public class OtherGenericClass : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            ClassWithGenericMethod myClass = new ClassWithGenericMethod();
            Debug.Log(myClass.GenericMethod<string>("teste"));
        }

    }
}

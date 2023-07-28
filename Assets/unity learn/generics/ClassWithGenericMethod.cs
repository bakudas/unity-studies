namespace unity_learn.generics
{
    public class ClassWithGenericMethod
    {
        public T GenericMethod<T>(T param)
        {
            return param;
        }
    }

}

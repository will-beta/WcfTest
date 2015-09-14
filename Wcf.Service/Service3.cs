namespace Wcf
{
    public class Service3 : IService3
    {
        public string DoWork(string str)
        {
            return string.Format("{0} : {1}", str, this);
        }
    }
}


namespace PetApi.Init
{
    public static class InitClass
    {
        public static T[] Init<T>(int num) where T : new()
        {
            var ret  = new List<T>();   
            for (int i = 0; i < num; i++)
            {
                ret.Add(new T());
            }
            return ret.ToArray();
        }
    }
}

namespace VectoAPI.Factory
{
    public class MethodFactory
    {
        public static IMethod Create(string pluginName)
        {
            return Activator.CreateInstance(Type.GetType("VectoAPI.Factory." + pluginName + "Method")) as IMethod;
        }
    }
}

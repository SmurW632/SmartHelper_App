using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace SmartHelper.Server.Services
{
    public class EngineModelPython
    {
        public void StartScript()
        {
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();

            var request = "i want to buy ***";

            scope.SetVariable("result", request);

            engine.Execute("list(result)", scope);
            var list = engine;
            var result = (string)scope.GetVariable("result");
            var items = result.Split(' ');

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using Newtonsoft.Json;

namespace ApplicationCsharp.builder
{
    internal abstract class JsonBuilder<T>
    {
        protected static T Build(string name)
        {
            string workingDirectory = Environment.CurrentDirectory;

            if (workingDirectory is null || Directory.GetParent(workingDirectory) is null)
            {
                throw new Exception();
            }

            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string concat = $"{projectDirectory}\\builder\\json\\{name}.json";

            using (StreamReader r = new StreamReader(concat))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(json);
            }
        }
    }
}

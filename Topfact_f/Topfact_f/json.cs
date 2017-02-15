using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;


namespace Topfact_f
{
    public class json
    {
        //private List<Task> tasks;

        /*internal List<Task> Tasks
        {
            get
            {
                return tasks;
            }

            set
            {
                tasks = value;
            }
        }*/

        internal List<Task> Tasks { get; set; }

        internal List<Task> LoadJson()
        {
            var assembly = typeof(Task).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("Topfact_f.data.json");


            using (var sr = new System.IO.StreamReader(stream))
            {
                var json = sr.ReadToEnd();
                Tasks = JsonConvert.DeserializeObject<List<Task>>(json);
            }
            return Tasks;
        }
    }
}

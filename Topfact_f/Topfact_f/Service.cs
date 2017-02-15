using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topfact_f;

namespace Topfact_f
{
    public class Service
    {
            public List<Task> getTaskArray()
            {
                json js = new Topfact_f.json();
                var task = js.LoadJson();
                return task;
            }
        
    }
}

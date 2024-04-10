using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo;

public class PhoneCaller : IContactService
{

    public void Send(string message, string name) => Console.WriteLine($"\"{message}\" was sent to {name} via phone call.");
    
}

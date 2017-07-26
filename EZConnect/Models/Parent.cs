using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EZConnect.Models
{
    class Parent : Person
    {
        public ICollection<Child> Children = new Collection<Child>();
    }
}

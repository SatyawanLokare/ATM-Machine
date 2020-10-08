using System;
using System.Collections.Generic;
using System.Text;

namespace BrainWork.ATM.Data
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}

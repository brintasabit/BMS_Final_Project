using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_Final.Model
{
    class Category
    {
        private string code;
        private string name;

        public string Code
        {
            get => code;
            set => code = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

    }
}

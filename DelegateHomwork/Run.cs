using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomework
{
    class Run
    {
        public void RunF(Func func,string word) {
            func.Invoke(word);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application
{
    public class TesteAsync
    {
        public int Processar1()
        {
            Method1();
            return 1;
        }

        public int Processar2()
        {
            Method2();
            return 2;
        }

        public int Processar3()
        {
            Method3();
            return 3;
        }

        public async Task<int> ProcessarAsync1()
        {
            await new Task(Method1);
            return 1;
        }
        public async Task<int> ProcessarAsync2()
        {
            await new Task(Method2);
            return 1;
        }
        public async Task<int> ProcessarAsync3()
        {
            await new Task(Method3);
            return 1;
        }

        private void Method1()
        {
            Thread.Sleep(10000);
        }

        private void Method2()
        {
            Thread.Sleep(10000);
        }

        private void Method3()
        {
            Thread.Sleep(10000);
        }
    }
}

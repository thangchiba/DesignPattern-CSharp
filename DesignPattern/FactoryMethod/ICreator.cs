using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExam
{
    public interface ICreator<T>
    {
        public abstract T FactoryMethod();
    }
}

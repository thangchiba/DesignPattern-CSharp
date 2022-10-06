using System;
namespace PrototypePattern
{
    public class Minion
    {
        private int id { get; set; }

        public Minion(int id)
        {
            this.id = id;
        }

        public Minion DeepCopy()
        {
            Minion clone = (Minion)this.MemberwiseClone();
            clone.id = this.id + 1;
            return clone;
        }

        public Minion ShallowCopy()
        {
            return (Minion)this.MemberwiseClone();
        }

        public override string? ToString()
        {
            return "My id is " + id;
        }
    }
}


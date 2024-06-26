using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektni1_AR
{
    public abstract class Register
    {
        protected ulong value;
        public ulong Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public void Reset()
        {
            value = 0;
        }

        public void Initialize(ulong InitialValue)
        {
            value = InitialValue;
        }

        public virtual void Increment()
        { 
            value++;
        }
        public virtual void Decrement()
        {
            value--;
        }
        public virtual string Serialize()
        {
            return value.ToString();
        }
        public virtual void Deserialize(string serializedValue)
        {
            if (ulong.TryParse(serializedValue, out ulong parsedValue))
            {
                value = parsedValue;
            }
            else
            {
                throw new ArgumentException("Invalid serialized value");
            }
        }

        public virtual bool Equals(Register other)
        {
            return this.value == other.value;
        }

    }
}

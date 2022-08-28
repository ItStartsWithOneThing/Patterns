using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class PhoneBuilder
    {
        public Phone phone { get; set; }

        public void CreatePhone()
        {
            phone = new Phone();
        }

        public abstract Phone GetPhone();

        public abstract void SetCamera();

        public abstract void SetModel();

        public abstract void SetOS();
    }
}

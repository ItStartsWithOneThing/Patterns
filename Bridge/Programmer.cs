using System;

namespace Bridge
{
    public abstract class Programmer
    {
        protected ILanguage Lang;

        public void SetLanguage(ILanguage lang)
        {
            Lang = lang;
        }

        public Programmer(ILanguage lang)
        {
            Lang = lang;
        }

        public virtual void DoWork()
        {
            Lang.Build();

            Lang.Execute();
        }

        public abstract void EarnMoney();
    }
}

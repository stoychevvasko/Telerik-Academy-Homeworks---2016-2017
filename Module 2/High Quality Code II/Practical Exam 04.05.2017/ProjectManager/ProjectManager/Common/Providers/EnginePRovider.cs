namespace ProjectManager.Common.Providers
{
    using Core.Models;

    public class EnginePRovider
    {
        private Engine instance;

        public EnginePRovider(Engine engine)
        {
            this.instance = engine;
        }

        public Engine Instance
        {
            get
            {
                return this.instance;
            }

            set
            {
                this.instance = value;
            }
        }

        public void Start()
        {
            this.instance.Start();
        }
    }
}

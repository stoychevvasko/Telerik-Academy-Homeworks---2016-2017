namespace ProjectManager.Framework.Core.Commands.Abstracts
{
    using Bytes2you.Validation;
    using Contracts;
    using Data;
    using Data.Factories;

    public abstract class CreationalCommand : Command, ICommand
    {
        protected readonly IModelsFactory Factory;

        public CreationalCommand(IModelsFactory factory, IDatabase database)
            : base(database)
        {
            Guard.WhenArgument(factory, "CreateProjectCommand ModelsFactory").IsNull().Throw();
            this.Factory = factory;
        }
    }
}

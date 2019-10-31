using Ninject.Modules;
using Text_Dominion.Factory;
using Text_Dominion.Factory.Interface;

namespace Text_Dominion.Ninject
{
    public class ApplicationNinjectBase : NinjectModule
    {
        public override void Load()
        {
            Kernel?.Bind<IDominionFactory>().To<DominionFactory>().InSingletonScope();
        }
    }
}

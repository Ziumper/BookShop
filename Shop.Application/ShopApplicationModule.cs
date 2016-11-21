using System.Reflection;
using Abp.Modules;

namespace Shop
{
    [DependsOn(typeof(ShopCoreModule))]
    public class ShopApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

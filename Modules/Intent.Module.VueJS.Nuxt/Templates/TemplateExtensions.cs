using System.Collections.Generic;
using Intent.Module.VueJS.Nuxt.Templates.NuxtConfigTs;
using Intent.Module.VueJS.Nuxt.Templates.TsconfigJson;
using Intent.Modules.Common.Templates;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: DefaultIntentManaged(Mode.Fully, Targets = Targets.Usings)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.TemplateExtensions", Version = "1.0")]

namespace Intent.Module.VueJS.Nuxt.Templates
{
    public static class TemplateExtensions
    {
        public static string GetNuxtConfigTsName<T>(this IntentTemplateBase<T> template)
        {
            return template.GetTypeName(NuxtConfigTsTemplate.TemplateId);
        }

        public static string GetTsconfigJsonName<T>(this IntentTemplateBase<T> template)
        {
            return template.GetTypeName(TsconfigJsonTemplate.TemplateId);
        }

    }
}
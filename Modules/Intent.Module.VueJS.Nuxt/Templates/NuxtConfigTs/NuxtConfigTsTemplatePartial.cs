using System.Collections.Generic;
using Intent.Engine;
using Intent.Modules.Common.Templates;
using Intent.Modules.Common.TypeScript.Templates;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.TypeScript.Templates.TypescriptTemplatePartial", Version = "1.0")]

namespace Intent.Module.VueJS.Nuxt.Templates.NuxtConfigTs
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class NuxtConfigTsTemplate : TypeScriptTemplateBase<object>
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Intent.Module.VueJS.Nuxt.NuxtConfigTs";

        [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
        public NuxtConfigTsTemplate(IOutputTarget outputTarget, object model = null) : base(TemplateId, outputTarget, model)
        {
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        public override ITemplateFileConfig GetTemplateFileConfig()
        {
            return new TypeScriptFileConfig(
                className: $"nuxt.config.ts",
                fileName: $"nuxt.config.ts"
            );
        }

    }
}
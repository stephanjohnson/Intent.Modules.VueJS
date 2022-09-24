using System.Collections.Generic;
using Intent.Engine;
using Intent.Modules.Common.Html.Templates;
using Intent.Modules.Common.Templates;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Html.Templates.HtmlFileTemplatePartial", Version = "1.0")]

namespace Intent.Module.VueJS.Nuxt.Templates.Layouts.DefaultVue
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class DefaultVueTemplate : HtmlTemplateBase<object>
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Intent.Module.VueJS.Nuxt.layouts.DefaultVue";

        [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
        public DefaultVueTemplate(IOutputTarget outputTarget, object model = null) : base(TemplateId, outputTarget, model)
        {
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        public override ITemplateFileConfig GetTemplateFileConfig()
        {
            return new HtmlFileConfig(
                fileName: $"default.vue",
                relativeLocation: ""
            );
        }

    }
}
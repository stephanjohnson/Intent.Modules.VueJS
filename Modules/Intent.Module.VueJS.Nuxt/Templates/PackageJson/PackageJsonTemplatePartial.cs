using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.ProjectItemTemplate.Partial", Version = "1.0")]

namespace Intent.Module.VueJS.Nuxt.Templates.PackageJson
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class PackageJsonTemplate : IntentTemplateBase<object>
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Intent.Module.VueJS.Nuxt.package.json";

        [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
        public PackageJsonTemplate(IOutputTarget outputTarget, object model = null) : base(TemplateId, outputTarget, model)
        {
        }

        public override ITemplateFileConfig GetTemplateFileConfig()
        {
            return new TemplateFileConfig(
                fileName: $"package.json",
                fileExtension: "txt"
            );
        }
    }
}
${
    using System.Text;
    using Typewriter.Extensions.WebApi;

    Template(Settings settings) {
        settings.IncludeProject("Blokitect.Data");
        settings.OutputExtension = "ts";
        settings.OutputFilenameFactory = (file) => {
            return file.Name
            .Replace(file.Name.First().ToString(), file.Name.First().ToString().ToLower())
            .Replace("ViewModel", "-model")
            .Replace(".cs", string.Empty);
        };
    }

    string foreignImports(Class c) {
        var importRules = new StringBuilder();

        foreach(var property in c.Properties
                                 .Select(i => i.Type)
                                 .Where(i => i.Name.Contains("ViewModel")).Distinct()) { 
            var source = 
                property.Name.Replace("[]", string.Empty);
            
            var from = 
                property.name
                .Replace("ViewModel", string.Empty)
                .Replace("Create", string.Empty)
                .Replace("[]", string.Empty)
                .Replace("Edit", string.Empty);

                importRules.Append($"import {{ {source} }} from './{from}-model';\r");
        
        }
        
        return importRules.ToString() ?? string.Empty;
    
    }

    string importBaseClass(File f) {

        var linesOfImport = new StringBuilder();
        var mainClass = f.Classes.Where(i => i.Name.Contains("ViewModel")).FirstOrDefault();

        if(mainClass != null) {
            if(mainClass.BaseClass != null) {
                var from = mainClass.BaseClass.name.Replace("ViewModel", string.Empty);
                var importRule = $"import {{ {mainClass.BaseClass} }} from './{from}-model';\r";
                linesOfImport.Append(importRule);
            }
        }

        return linesOfImport.ToString();
    }
    
    string importEnums(Class c) { 
        string imports = "";

        foreach(var property in c.Properties) {
        if(property.Type.IsEnum)
            imports += $"{property.Type}, ";
        }

        return c.Properties.Any(i => i.Type.IsEnum) ? $"import {{ {imports} }} from './enums';\r" : string.Empty;
    }

    string className(Class c) {
        return c.BaseClass != null ? $"{c.Name} extends {c.BaseClass.Name}" : c.Name; 
    } 
}
$importBaseClass$Classes(*ViewModel)[$importEnums$foreignImports
export class $className { $Properties[ 
    public $name: $Type; 
]
}
]
//end of file

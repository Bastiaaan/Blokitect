${
Template(Settings settings) {
    settings.IncludeProject("Blokitect.Data");
    settings.OutputExtension = "ts";
    settings.OutputFilenameFactory = (file) => {
        return file.Name.ToLowerInvariant().Replace(".cs", string.Empty);
    };
}

}$Enums(*Models.Enums.*)[
export enum $Name { $Values[
    $Name = $Value][,]
}
]
 
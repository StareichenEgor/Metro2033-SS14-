using Content.Client.CrewManifest.UI;
using Content.Shared.CrewManifest;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.CrewManifest;

[GenerateTypedNameReferences]
public sealed partial class CrewManifestUi : DefaultWindow
{
    public CrewManifestUi()
    {
        RobustXamlLoader.Load(this);

        StationName.AddStyleClass("LabelBig");
    }

    public void Populate(string name, CrewManifestEntries? entries)
    {
        CrewManifestListing.DisposeAllChildren();
        CrewManifestListing.RemoveAllChildren();

        StationNameContainer.Visible = entries != null;
        StationName.Text = name;

        if (entries == null)
            return;

        CrewManifestListing.AddCrewManifestEntries(entries);
    }
}
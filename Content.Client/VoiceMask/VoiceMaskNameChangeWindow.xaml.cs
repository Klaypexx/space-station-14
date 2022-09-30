using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.VoiceMask;

[GenerateTypedNameReferences]
public sealed partial class VoiceMaskNameChangeWindow : DefaultWindow
{
    public Action<string>? OnNameChange;

    public VoiceMaskNameChangeWindow()
    {
        RobustXamlLoader.Load(this);

        NameSelectorSet.OnPressed += _ =>
        {
            OnNameChange!(NameSelector.Text);
        };
    }

    public void UpdateState(string name)
    {
        NameSelector.Text = name;
    }
}

namespace MediocreSoundDesigner;

public partial class FrmEditHighPass : FrmEditMaster
{
    public FrmEditHighPass()
    {
        InitializeComponent();
    }

    protected override void Init()
    {
        base.Init();
    }

    protected override void Apply()
    {
        track.HighPass((float)nudFreq.Value);
    }

}

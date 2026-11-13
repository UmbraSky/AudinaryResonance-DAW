namespace MediocreSoundDesigner;

public partial class FrmEditLowPass : FrmEditMaster
{
    public FrmEditLowPass()
    {
        InitializeComponent();
    }

    protected override void Init()
    {
        base.Init();
    }

    protected override void Apply()
    {
            track.LowPass((float)nudFreq.Value);
    }


}

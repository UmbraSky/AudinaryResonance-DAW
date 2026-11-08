namespace MediocreSoundDesigner;

public partial class FrmEditPitch : FrmEditMaster
{
    public FrmEditPitch()
    {
        InitializeComponent();
    }

    protected override void Init()
    {
        base.Init();
        nudSemitones.Value = (decimal)(track.Pitch);
    }

    protected override void Apply()
    {
        track.PitchShift((float)nudSemitones.Value);
    }

    private void nudSemitones_ValueChanged(object sender, EventArgs e)
    {
        int curVal = (int)nudSemitones.Value;
        string[] keys = ["C", "C♯", "D", "D♯", "E", "F", "F♯", "G", "G♯", "A", "A♯", "B", "C"];

        string octave = curVal switch
        {
            > 0 => "5",
            < 0 => "3",
            _ => "4"
        };

        string postKey = (curVal > 0) ? keys[curVal] : keys[12 + curVal];

        lblPostKey.Text = postKey + octave;
    }
}

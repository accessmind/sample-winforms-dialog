namespace SampleWinFormsDialog;

public partial class MainForm: Form {
    public MainForm() {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
        Dialog form2 = new Dialog();
        form2.ShowDialog();
    }
}

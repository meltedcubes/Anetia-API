# Anetia API

## Setup
```csharp
using AnetiaApi;

// Create instance
static AnetiaApi.Main Anetia = new AnetiaApi.Main();
Anetia.InvokeApi()
```

## Methods

| Method | Description | Example |
|--------|-------------|---------|
| `InvokeApi()` | Initialize API | `Anetia.InvokeApi();` |
| `Execute(string script)` | Run a script | `Anetia.Execute("print('hi')");` |
| `Inject()` | Inject into Roblox | `Anetia.Inject();` |
| `IsAttached()` | Check if injected | `bool attached = Anetia.IsAttached();` |

## Windows Forms Example
```csharp
public partial class Form1 : Form
{
    static AnetiaApi.Main Anetia;

    public Form1()
    {
        InitializeComponent();
        Anetia = new AnetiaApi.Main();
        Anetia.InvokeApi();
    }

    // Run script
    private void button1_Click(object sender, EventArgs e)
    {
        Anetia.Execute(richTextBox1.Text);
    }

    // Inject
    private void button2_Click(object sender, EventArgs e)
    {
        Anetia.Inject();
    }

    // Check attached
    private void button3_Click(object sender, EventArgs e)
    {
        MessageBox.Show(Anetia.IsAttached() ? "Attached!" : "Not attached");
    }
}
```

## Requirements
- `%LocalAppData%/Anetia/Workspace/exec.txt` (auto-created)
- `%LocalAppData%/AnetiaInstallation/Loader.exe`
- `Init.exe` in working directory ( Anetia's installer )

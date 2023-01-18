using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using static System.Console;
using System.Management;
using System;

//���������, ���������������� ��������� WM _ SETTEXT
const uint WM_SETTEXT = 0x0C;
//����������� ������� SendMEssage �� ����������
//user32.dll
[DllImport("user32.dll")]
static extern IntPtr SendMessage(IntPtr hwnd,
uint Msg, int wParam,
[MarshalAs(UnmanagedType.LPStr)] string lParam);
/*������, � ������� ����� ��������� �������,
* ����������� �������� �������� ����������*/
List<Process> Processes = new List<Process>();
/*������� ���������� ���������*/
int Counter = 0;


/*�����, ����������� ��������� �����������
* ����� �� �������� ���������� �������*/
void LoadAvailableAssemblies()
{
    //�������� ����� ������ �������� ����������
    string except = new FileInfo(Application.ExecutablePath).Name;
    //�������� �������� ����� ��� ����������
    except = except.Substring(0, except.IndexOf("."));
    //�������� ��� *.exe ����� �� ��������
    //����������
    string[] files = Directory.GetFiles(Application.
    StartupPath, "*.exe");
    foreach (var file in files)
    {
        //�������� ��� �����
        string fileName = new FileInfo(file).Name;
        /*���� ��� ����� �� �������� ����� ������������
        *����� �������, �� ��� ����������� � ������*/
        if (fileName.IndexOf(except) == -1)
            AvailableAssemblies.Items.Add(fileName);
    }
}



namespace dotcer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {

        }

        private void button_Stop_Click(object sender, EventArgs e)
        {

        }

        private void button_CloseWindow_Click(object sender, EventArgs e)
        {

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void button_RunNotepade_Click(object sender, EventArgs e)
        {

        }

        private void StartedAssemblies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AvailableAssemblies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void LoadAvailableAssemblies()
        {            string except = new FileInfo(Application.
            ExecutablePath).Name;
            except = except.Substring(0, except.
            IndexOf("."));
            string[] files = Directory.GetFiles(Application.
            StartupPath, "*.exe");
            foreach (var file in files)
            {
                string fileName = new FileInfo(file).Name;
                if (fileName.IndexOf(except) == -1)
                    AvailableAssemblies.Items.Add(fileName);
            }
        }


        void RunProcess(string AssamblyName)
        {
            Process proc = Process.Start(AssamblyName);
            Processes.Add(proc);
            if (Process.GetCurrentProcess().Id == GetParentProcessId(proc.Id))
                MessageBox.Show(proc.ProcessName + " ������������� �������� ������� �������� ��������!");
            proc.EnableRaisingEvents = true;
            proc.Exited += proc_Exited;

            SetChildWindowText(proc.MainWindowHandle, "Child process #" + (++Counter));
            if (!StartedAssemblies.Items.Contains(proc.ProcessName))
                StartedAssemblies.Items.Add(proc.ProcessName);

            AvailableAssemblies.Items.
            Remove(AvailableAssemblies.SelectedItem);
        }
    }
}
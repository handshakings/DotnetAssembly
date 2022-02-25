using System.Reflection;
using System.Text;

namespace DotnetAssembly
{
#nullable disable
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadExeInMemory_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                //AppDomain.CurrentDomain.ExecuteAssembly(openFileDialog1.FileName);
                //AppDomain.CreateDomain("mydomain").ExecuteAssembly(openFileDialog1.FileName);

                string filePath = openFileDialog1.FileName;
                byte[] buff = File.ReadAllBytes(filePath);


                Assembly assem = Assembly.Load(buff);


                MethodInfo method = assem.GetType().GetMethod("Add");

                //MethodInfo method = assem.EntryPoint;
                var o = assem.CreateInstance(method.Name);
                method.Invoke(o, new object[] {3,5});


                //Assembly assem = Assembly.Load(buff);
                //MethodInfo method = assem.EntryPoint;
                //var o = Activator.CreateInstance(method.DeclaringType);
                //method.Invoke(o, null);


                //Assembly asm = Assembly.LoadFile(filePath);
                //MethodInfo method = asm.EntryPoint;
                //if (method != null)
                //{
                //    create an instance of the Startup form Main method
                //   var o = asm.CreateInstance(method.Name);
                //    var o = Activator.CreateInstance(method.DeclaringType);
                //    Application.SetCompatibleTextRenderingDefault(true);
                //    invoke the application starting point
                //    method.Invoke(o, null);
                //}

            }
            
        }
    }
}
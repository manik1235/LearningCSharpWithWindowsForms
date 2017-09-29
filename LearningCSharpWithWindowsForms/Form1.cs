using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///   The purpose of this program is to collaboratively practice C#, perhaps by challenging each other
///   or working toward some specific goal. I'm not very familiar with C# yet, so let's see what happens!
/// </summary>
namespace LearningCSharpWithWindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///   When this button is clicked, it displays a message box saying hello to whomever 
        ///   is listed in the associated text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelloButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Concat("Hello ",  nameTextBox.Text));
        }


    }
}

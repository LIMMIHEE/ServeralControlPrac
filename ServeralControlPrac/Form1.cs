using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServeralControlPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Label label = new Label();
            label.Text = "나의 기술 블로구ㅡ";
            label.Location = new Point(10, 10);
            Controls.Add(label);

            LinkLabel linkLabel = new LinkLabel();
            linkLabel.Text = "https://helloworld-limmihee.tistory.com/";
            linkLabel.Location = new Point(10, 50);
            linkLabel.Click += LabelClick;
            Controls.Add(linkLabel);


            CheckBox checkBox1 = new CheckBox();
            CheckBox checkBox2 = new CheckBox();
            CheckBox checkBox3 = new CheckBox();
            Button button = new Button();

            checkBox1.Text = "토마토";
            checkBox2.Text = "감자";
            checkBox3.Text = "새우";
            button.Text = "클릭!!";

            button.Click += ButtonClick;

            checkBox1.Location = new Point(20, 150);
            checkBox2.Location = new Point(20, 190);
            checkBox3.Location = new Point(20, 230);
            button.Location = new Point(20, 120);

            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox3);
            Controls.Add(button);

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            List<String> list = new List<string>();

            foreach (var item in Controls)
            {
                if(item is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)item;
                    if (checkBox.Checked)
                    {
                        list.Add(checkBox.Text);
                    }
                }

            }

            MessageBox.Show(String.Join(",", list));
        }

        private void LabelClick(object sender, EventArgs e)
        {
            System.Diagnostics
                //.Process.Start("https://helloworld-limmihee.tistory.com/");
                .Process.Start("notepad.exe");

        }
    }
}

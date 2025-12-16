using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlatUI
{
    public class FlatMessageBox : Form
    {
        #region 初始化按钮
        private void button_init(Button button)
        {
            button.BackColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("微软雅黑", 10);
            button.FlatAppearance.BorderColor = Color.Black;
            button.FlatAppearance.MouseOverBackColor = Color.Black;
            button.FlatAppearance.MouseDownBackColor = Color.Black;
            button.MouseEnter += button_WinSignIn_SignIn_MouseEnter;
            button.MouseLeave += button_Lev;
        }
        private void button_WinSignIn_SignIn_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.White;
        }
        private void button_Lev(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.Black;
        }
        #endregion

        Button[] buttons = new Button[2];
        Label[] labels = new Label[1];
        public FlatMessageBox()
        {
            this.Size = new Size(320, 200);
            this.BackColor = Color.White;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;


            labels[0] = new Label();
            labels[0].Text = "";
            labels[0].Anchor = AnchorStyles.None;
            labels[0].AutoSize = true;
            labels[0].Font = new Font("微软雅黑", 12);
            this.Controls.Add(labels[0]);

            buttons[0] = new Button();
            buttons[0].Text = "确定";
            button_init(buttons[0]);
            buttons[0].Font = new Font("微软雅黑", 10);
            buttons[0].Width = 150;
            buttons[0].Height = 50;
            buttons[0].Location = new Point(1, this.Height - 90);
            buttons[0].FlatAppearance.BorderColor = Color.White;
            buttons[0].Click += MyMessageBox1_Click1;
            buttons[0].Anchor = AnchorStyles.None;
            this.Controls.Add(buttons[0]);

            buttons[1] = new Button();
            buttons[1].Location = new Point(153, buttons[0].Location.Y);
            buttons[1].Text = "取消";
            button_init(buttons[1]);
            buttons[1].Font = new Font("微软雅黑", 10);
            buttons[1].Width = 150;
            buttons[1].Height = 50;
            buttons[1].FlatAppearance.BorderColor = Color.White;
            buttons[1].Click += MyMessageBox1_Click;
            buttons[1].Anchor = AnchorStyles.None;
            this.Controls.Add(buttons[1]);
        }
        //当点击右上角叉叉的时候默认返回cancel
        string theClickButton = "cancel";
        private void MyMessageBox1_Click1(object sender, EventArgs e)
        {
            theClickButton = "confirm";
            this.Close();
        }

        private void MyMessageBox1_Click(object sender, EventArgs e)
        {
            theClickButton = "cancel";
            this.Close();
        }

        public string showMessage(string text)
        {

            labels[0].Text = text;
            labels[0].Location = new Point(this.Width / 2 - labels[0].Width / 2 - 10, this.Height / 2 - labels[0].Height / 2 - 45);
            //ShowDialog相当于线程暂停 此处的话就需要close或者dispose以后才会 return theClickButton;
            this.ShowDialog();
            return theClickButton;
        }
    }
}

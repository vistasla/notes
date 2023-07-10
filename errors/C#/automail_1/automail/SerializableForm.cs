using System;
using System.Windows.Forms;
namespace automail
{
    [Serializable]
    // public class SerializableForm
    class SerializableForm
    {
        //public MyTextBox textBox = new MyTextBox();
        //public MyButton button = new MyButton();
        //[NonSerialized] public TextBox textBox = new TextBox();
        //[NonSerialized] public Button button = new Button();
        // public SerializableForm()
       // public TextBox textBox;
        public SerializableForm()
        {

            Form form = new Form();
            TextBox textBox = new TextBox();
            // textBox = new TextBox();
            textBox.Text = "hello world";
            Button button = new Button();
            form.SetBounds((Screen.PrimaryScreen.Bounds.Width - 800) / 2, (Screen.PrimaryScreen.Bounds.Height - 450) / 2, 800, 450);
            form.StartPosition = FormStartPosition.CenterScreen;
            textBox.SetBounds(300, 100, 200, 40);
            button.SetBounds(300, 200, 200, 80);
            button.Click += Button_Click;
            void Button_Click(object sender, EventArgs e)
            {
                textBox.Text = "hello world";
            }
            form.Controls.Add(textBox);
            form.Controls.Add(button);
            form.Show();
            form.Close();
        }


    }
}

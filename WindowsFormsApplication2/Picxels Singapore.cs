using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private Image bg1;
        private Image bg2;
        private Image bg3;
        private Image bg4;
        private Image bg5;
        private Bitmap smallerpictureboxd;
        int piccount = 1;

        public Image b1 { get; private set; }
        public Image b2 { get; private set; }
        public Image b3 { get; private set; }
    public    OpenFileDialog openFileDialog = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
            List<string> fonts = new List<string>();

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                comboBox1.Items.Add(font.Name);
                comboBox2.Items.Add(font.Name);
            }

            comboBox1.Text = "Segoe Script";
            comboBox2.Text = "Agency FB";

            openFileDialog.Filter = "Image files (*.png, *.jpg, *.jpeg, *.jpe, *.jfif) | *.jpg; *.jpeg; *.jpe; *.png";

            ShowPreviewResize();

        }

        public void ShowPreviewResize()
        {
            //  if (smallerpictureboxd != null)
            //  {
            //    smallerpictureboxd.Dispose();
            // }

            //  if (smallerpicturebox.Image != null)
            //{
            // smallerpicturebox.Image.Dispose();
            //  }         
            try
            {
                smallerpictureboxd = new Bitmap(panel1.Width, panel1.Height);
                panel1.DrawToBitmap(smallerpictureboxd, new Rectangle(0, 0, smallerpictureboxd.Width, smallerpictureboxd.Height));
                smallerpicturebox.Image = smallerpictureboxd;
            }
            catch
            {
                MessageBox.Show("Error");
            }
 
        }

        public void PanelBGClear()
        {
         //   if (panel1.BackgroundImage != null)
          //  {
          //      panel1.BackgroundImage.Dispose();
          //  }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   openFileDialog = new OpenFileDialog();
            // "PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {        
                PanelBGClear();
                //   panel1.BackgroundImage = Bitmap.FromFile(openFileDialog.FileName);
                bg1 = Bitmap.FromFile(openFileDialog.FileName);
                radioButton1.Enabled = true;
                radioButton1.Checked = true;                
                panel1.BackgroundImage = bg1;
                ShowPreviewResize();                
            }
            openFileDialog.Dispose();
        }

        private void themebutton2_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {              
                PanelBGClear();
                bg2 = Bitmap.FromFile(openFileDialog.FileName);
                radioButton2.Enabled = true;
                radioButton2.Checked = true;               
                panel1.BackgroundImage = bg2;
                ShowPreviewResize();
            }
            openFileDialog.Dispose();
        }

        private void themebutton3_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PanelBGClear();
                bg3 = Bitmap.FromFile(openFileDialog.FileName);
                radioButton3.Enabled = true;
                radioButton3.Checked = true;
                panel1.BackgroundImage = bg3;
                ShowPreviewResize();
            }
            openFileDialog.Dispose();
        }

        private void themebutton4_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openFileDialog.Multiselect = false;
                PanelBGClear();
                bg4 = Bitmap.FromFile(openFileDialog.FileName);
                radioButton4.Enabled = true;
                radioButton4.Checked = true;
                panel1.BackgroundImage = bg4;               
                ShowPreviewResize();                
            }
            openFileDialog.Dispose();
        }

        private void themebutton5_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {  PanelBGClear();
                bg5 = Bitmap.FromFile(openFileDialog.FileName);
                radioButton5.Enabled = true;
                radioButton5.Checked = true;
                panel1.BackgroundImage = bg5;
                ShowPreviewResize();
            }
            openFileDialog.Dispose();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                panel1.BackgroundImage = bg1;

                ShowPreviewResize();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                panel1.BackgroundImage = bg2;

                ShowPreviewResize();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                panel1.BackgroundImage = bg3;

                ShowPreviewResize();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                panel1.BackgroundImage = bg4;

                ShowPreviewResize();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                panel1.BackgroundImage = bg5;

                ShowPreviewResize();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {          
            //   int picturecount = 6;
            PictureLocation.Items.Clear();
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                foreach (string filename in openFileDialog.FileNames)
                {
                    PictureLocation.Items.Add(filename);
                }
                try
                {
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox4.Image.Dispose();
                    }

                    if (pictureBox2.Image != null)
                    {
                        pictureBox2.Image.Dispose();
                        pictureBox5.Image.Dispose();
                    }

                    if (pictureBox3.Image != null)
                    {
                        pictureBox3.Image.Dispose();
                        pictureBox6.Image.Dispose();
                    }
                    //hidden
                     b1 = Bitmap.FromFile(PictureLocation.Items[0].ToString());
                     b2 = Bitmap.FromFile(PictureLocation.Items[1].ToString());
                     b3 = Bitmap.FromFile(PictureLocation.Items[2].ToString());
                    pictureBox1.Image = b1;
                    pictureBox4.Image = b1;
                    pictureBox2.Image = b2;
                    pictureBox5.Image = b2;
                    pictureBox3.Image = b3;
                    pictureBox6.Image = b3;

                    //to small
                    ShowPreviewResize();
                }
                catch
                {
                    MessageBox.Show("Please select 3 files.");
                }
            }         
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(panel1.ClientRectangle.Width, panel1.ClientRectangle.Height);
            panel1.DrawToBitmap(bmp, panel1.ClientRectangle);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void ccbutton_Click(object sender, EventArgs e)
        {
            if (ccbutton.Text == "Complete"
                )
            {
                themebutton1.Visible = false;
                themebutton2.Visible = false;
                themebutton3.Visible = false;
                themebutton4.Visible = false;
                themebutton5.Visible = false;
                importbutton.Visible = true;
                smallerpicturebox.Visible = true;
                themepanel.Enabled = true;
                ccbutton.Text = "Change";
            }
            else if (ccbutton.Text == "Change"
                )
            {
                themebutton1.Visible = true;
                themebutton2.Visible = true;
                themebutton3.Visible = true;
                themebutton4.Visible = true;
                themebutton5.Visible = true;
                importbutton.Visible = false;
                themepanel.Enabled = false;
                smallerpicturebox.Visible = false;
                ccbutton.Text = "Complete";
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
               saveFileDialog1.InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments);
               saveFileDialog1.FileName = "Picture " + piccount.ToString();
               saveFileDialog1.Filter = "PNG Files(*.png) | *.png";
              saveFileDialog1.FilterIndex = 1;

              if (saveFileDialog1.ShowDialog() == DialogResult.OK)
               {

                smallerpictureboxd.Save(saveFileDialog1.FileName);
                
                      piccount++;
              }          
            saveFileDialog1.Dispose();


        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            PrintDocument Pd = new PrintDocument();
            PrinterSettings PrinterSetting = new PrinterSettings();
            Pd.PrinterSettings.PrinterName = "Microsoft XPS Document Writer";
            Pd.PrinterSettings.Copies = 1;
            Pd.PrinterSettings.DefaultPageSettings.Landscape = true;

            Pd.PrintPage += printDocument1_PrintPage;
            ppd.Document = Pd;
            ((Form)ppd).WindowState = FormWindowState.Maximized;
            ppd.ShowDialog();
        }

        private void Changebutton_Click(object sender, EventArgs e)
        {
            label1.Text = maintextbox.Text;
            label2.Text = maintextbox.Text;

            int mainsize = int.Parse(maintextsize.Text);
            label1.Font = new Font(comboBox1.Text, mainsize, FontStyle.Bold);
            label2.Font = new Font(comboBox1.Text, mainsize, FontStyle.Bold);

            int X = decimal.ToInt32(numericUpDown1.Value);
            int Y = decimal.ToInt32(numericUpDown2.Value);
            label1.Location = new Point(X, Y);
            label2.Location = new Point((X+600), Y);

            //

            sublabel1.Text = subtextbox.Text;
            sublabel2.Text = subtextbox.Text;

            int subsize = int.Parse(subtextsize.Text);
            sublabel1.Font = new Font(comboBox2.Text, subsize, FontStyle.Bold);
            sublabel2.Font = new Font(comboBox2.Text, subsize, FontStyle.Bold);

            int sXi = decimal.ToInt32(numericUpDown3.Value);
            int sYi = decimal.ToInt32(numericUpDown4.Value);
            sublabel1.Location = new Point(sXi, sYi);
            sublabel2.Location = new Point((sXi + 600), sYi);

            ShowPreviewResize();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Changebutton.PerformClick();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Changebutton.PerformClick();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Changebutton.PerformClick();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            Changebutton.PerformClick();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Changebutton.PerformClick();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Changebutton.PerformClick();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            ShowPreviewResize();
        }

        private void noneradioButton_CheckedChanged(object sender, EventArgs e)
        {

                blackboarderpanel.BackgroundImage = null;
                blackboarderpanel2.BackgroundImage = null;
                ShowPreviewResize();
        }

        private void whiteradioButton_CheckedChanged(object sender, EventArgs e)
        {
            blackboarderpanel.BackgroundImage = PicxelsSingapore.Properties.Resources.borderwhite;
            blackboarderpanel2.BackgroundImage = PicxelsSingapore.Properties.Resources.borderwhite;
            ShowPreviewResize();
        }

        private void blackradioButton_CheckedChanged(object sender, EventArgs e)
        {
            blackboarderpanel.BackgroundImage = PicxelsSingapore.Properties.Resources.borderblack;
            blackboarderpanel2.BackgroundImage = PicxelsSingapore.Properties.Resources.borderblack;
            ShowPreviewResize();
        }

        private void nonetitleradiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (nonetitleradiobutton.Checked == true)
            {
                titlepanel1.BackgroundImage = null;
                titlepanel2.BackgroundImage = null;
                ShowPreviewResize();
            }
        }

        private void whitetitleradiobutton_CheckedChanged(object sender, EventArgs e)
        {
            titlepanel1.BackgroundImage = title1;
            titlepanel2.BackgroundImage = title1;
            ShowPreviewResize();
        }

        private void blacktitleradiobutton_CheckedChanged(object sender, EventArgs e)
        {
            titlepanel1.BackgroundImage = title2;
            titlepanel2.BackgroundImage = title2;
            ShowPreviewResize();
        }

        private void titlewhitebutton_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PanelBGClear();
                title1 = Bitmap.FromFile(openFileDialog.FileName);
                whitetitleradiobutton.Enabled = true;
                whitetitleradiobutton.Checked = true;
                titlepanel1.BackgroundImage = title1;
                titlepanel2.BackgroundImage = title1;
                ShowPreviewResize();
            }
            openFileDialog.Dispose();
        }

        public Image title1 { get; set; }

        public Image title2 { get; set; }

        private void titleblackbutton_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PanelBGClear();
                title2 = Bitmap.FromFile(openFileDialog.FileName);
                blacktitleradiobutton.Enabled = true;
                blacktitleradiobutton.Checked = true;
                titlepanel1.BackgroundImage = title2;
                titlepanel2.BackgroundImage = title2;
                ShowPreviewResize();
            }
            openFileDialog.Dispose();
        }
    }
}

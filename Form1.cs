namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //Show the Open file dialog. If the user click OK, load the picture that the user chose.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the file extension
                string fileExtension = System.IO.Path.GetExtension(openFileDialog1.FileName).ToLower();

                // Check if the file is an image (you can add more extensions as needed)
                if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" ||
                    fileExtension == ".bmp" || fileExtension == ".gif" || fileExtension == ".tiff")
                {
                    // Load the picture
                    pictureBox1.Load(openFileDialog1.FileName);
                }
                else
                {
                    // Show an error message if the file is not an image
                    MessageBox.Show("The selected file is not a valid image file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the picture.
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            //Show the color dialog box. If the user click OK, change the
            //PictureBox control's background to the color the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //close the form.
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { //If the user selects the Stretch check box,
            //change the PictureBox's 
            //SizeMode property to "Stretch". If the user clears
            //the check box, change it to "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}

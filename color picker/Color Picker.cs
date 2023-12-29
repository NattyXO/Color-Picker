using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace color_picker
{
    public partial class Form1 : Form
    {

        Dictionary<string, string> colorDictionary = new Dictionary<string, string>()
{
    { "red", "#FF0000" },
    { "green", "#008000" },
    { "blue", "#0000FF" },
    { "yellow", "#FFFF00" },
    { "orange", "#FFA500" },
    { "purple", "#800080" },
    { "pink", "#FFC0CB" },
    { "black", "#000000" },
    { "white", "#FFFFFF" },
    { "brown", "#A52A2A" },
    { "gray", "#808080" },
    { "silver", "#C0C0C0" },
    { "gold", "#FFD700" },
    { "cyan", "#00FFFF" },
    { "magenta", "#FF00FF" },
    { "teal", "#008080" },
    { "navy", "#000080" },
    { "olive", "#808000" },
    { "maroon", "#800000" },
    { "lime", "#00FF00" },
    { "aqua", "#00FFFF" },
    { "fuchsia", "#FF00FF" },
    { "indigo", "#4B0082" },
    { "violet", "#8A2BE2" },
    { "orchid", "#DA70D6" },
    { "coral", "#FF7F50" },
    { "khaki", "#F0E68C" },
    { "azure", "#F0FFFF" },
    { "lavender", "#E6E6FA" },
    { "turquoise", "#40E0D0" },
    { "salmon", "#FA8072" },
    { "sienna", "#A0522D" },
    { "thistle", "#D8BFD8" },
    { "peru", "#CD853F" },
    { "tomato", "#FF6347" },
    { "cornflower", "#6495ED" },
    { "skyblue", "#87CEEB" },
    { "tan", "#D2B48C" },
    { "bisque", "#FFE4C4" },
    { "chartreuse", "#7FFF00" },
    { "darkgreen", "#006400" },
    { "hotpink", "#FF69B4" },
    { "darkorange", "#FF8C00" },
    { "slategray", "#708090" },
    { "olivedrab", "#6B8E23" },
    { "saddlebrown", "#8B4513" },
    { "steelblue", "#4682B4" },
    { "palegreen", "#98FB98" },
    { "plum", "#DDA0DD" },
   
};

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The window will close.", "Closing window..", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copy the HEXA CODE to clipboard and past it,To view more down dropdown the scrole and to view more up dropup the scrole ");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Setting ss = new Setting();
            ss.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }


        private void picGithub_Click(object sender, EventArgs e)
        {
            string githubUrl = "https://github.com/NattyXO";

            // Open the default browser with the specified URL
            Process.Start(githubUrl);
        }

        private void picAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Nahu\nImprovement by NattyXO\nVersion v1.0\nAhadu Tech 2023");
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
            this.Refresh();
        }

        private void txtColor1_TextChanged(object sender, EventArgs e)
        {
            // Get the entered hexadecimal color code
            string hexColor = txtColor1.Text.Trim();

            // Check if the entered value is a valid hexadecimal color code
            if (System.Text.RegularExpressions.Regex.IsMatch(hexColor, "^#(?:[0-9a-fA-F]{3}){1,2}$"))
            {
                // Convert the hexadecimal color to a Color object
                Color newColor = ColorTranslator.FromHtml(hexColor);

                // Set the BackColor of pic1 to the entered color
                pnl1.BackColor = newColor;

                // Find the closest named color to the entered color
                string colorName = "";
                foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
                {
                    Color namedColor = Color.FromKnownColor(knownColor);
                    if (namedColor.ToArgb() == newColor.ToArgb())
                    {
                        colorName = knownColor.ToString();
                        break;
                    }
                }

                // Display the closest named color in lblColor1
                lblColor1.Text = colorName != "" ? colorName : "Custom Color";
            }
            else
            {
                // If the entered value is not a valid hexadecimal color code
                lblColor1.Text = "Invalid Color";
            }
        }


        private void txtColor2_TextChanged(object sender, EventArgs e)
        {
            // Get the entered hexadecimal color code
            string hexColor = txtColor2.Text.Trim();

            // Check if the entered value is a valid hexadecimal color code
            if (System.Text.RegularExpressions.Regex.IsMatch(hexColor, "^#(?:[0-9a-fA-F]{3}){1,2}$"))
            {
                // Convert the hexadecimal color to a Color object
                Color newColor = ColorTranslator.FromHtml(hexColor);

                // Set the BackColor of pic1 to the entered color
                pnl2.BackColor = newColor;

                // Find the closest named color to the entered color
                string colorName = "";
                foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
                {
                    Color namedColor = Color.FromKnownColor(knownColor);
                    if (namedColor.ToArgb() == newColor.ToArgb())
                    {
                        colorName = knownColor.ToString();
                        break;
                    }
                }

                // Display the closest named color in lblColor1
                lblColor2.Text = colorName != "" ? colorName : "Custom Color";
            }
            else
            {
                // If the entered value is not a valid hexadecimal color code
                lblColor2.Text = "Invalid Color";
            }
        }

        private void txtColor3_TextChanged(object sender, EventArgs e)
        {
            // Get the entered hexadecimal color code
            string hexColor = txtColor3.Text.Trim();

            // Check if the entered value is a valid hexadecimal color code
            if (System.Text.RegularExpressions.Regex.IsMatch(hexColor, "^#(?:[0-9a-fA-F]{3}){1,2}$"))
            {
                // Convert the hexadecimal color to a Color object
                Color newColor = ColorTranslator.FromHtml(hexColor);

                // Set the BackColor of pic1 to the entered color
                pnl3.BackColor = newColor;

                // Find the closest named color to the entered color
                string colorName = "";
                foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
                {
                    Color namedColor = Color.FromKnownColor(knownColor);
                    if (namedColor.ToArgb() == newColor.ToArgb())
                    {
                        colorName = knownColor.ToString();
                        break;
                    }
                }

                // Display the closest named color in lblColor1
                lblColor3.Text = colorName != "" ? colorName : "Custom Color";
            }
            else
            {
                // If the entered value is not a valid hexadecimal color code
                lblColor3.Text = "Invalid Color";
            }
        }

        private void txtColor4_TextChanged(object sender, EventArgs e)
        {
            // Get the entered hexadecimal color code
            string hexColor = txtColor4.Text.Trim();

            // Check if the entered value is a valid hexadecimal color code
            if (System.Text.RegularExpressions.Regex.IsMatch(hexColor, "^#(?:[0-9a-fA-F]{3}){1,2}$"))
            {
                // Convert the hexadecimal color to a Color object
                Color newColor = ColorTranslator.FromHtml(hexColor);

                // Set the BackColor of pic1 to the entered color
                pnl4.BackColor = newColor;

                // Find the closest named color to the entered color
                string colorName = "";
                foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
                {
                    Color namedColor = Color.FromKnownColor(knownColor);
                    if (namedColor.ToArgb() == newColor.ToArgb())
                    {
                        colorName = knownColor.ToString();
                        break;
                    }
                }

                // Display the closest named color in lblColor1
                lblColor4.Text = colorName != "" ? colorName : "Custom Color";
            }
            else
            {
                // If the entered value is not a valid hexadecimal color code
                lblColor4.Text = "Invalid Color";
            }
        }

        private void txtColor5_TextChanged(object sender, EventArgs e)
        {
            // Get the entered hexadecimal color code
            string hexColor = txtColor5.Text.Trim();

            // Check if the entered value is a valid hexadecimal color code
            if (System.Text.RegularExpressions.Regex.IsMatch(hexColor, "^#(?:[0-9a-fA-F]{3}){1,2}$"))
            {
                // Convert the hexadecimal color to a Color object
                Color newColor = ColorTranslator.FromHtml(hexColor);

                // Set the BackColor of pic1 to the entered color
                pnl5.BackColor = newColor;

                // Find the closest named color to the entered color
                string colorName = "";
                foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
                {
                    Color namedColor = Color.FromKnownColor(knownColor);
                    if (namedColor.ToArgb() == newColor.ToArgb())
                    {
                        colorName = knownColor.ToString();
                        break;
                    }
                }

                // Display the closest named color in lblColor1
                lblColor5.Text = colorName != "" ? colorName : "Custom Color";
            }
            else
            {
                // If the entered value is not a valid hexadecimal color code
                lblColor5.Text = "Invalid Color";
            }
        }

        private void txtColor6_TextChanged(object sender, EventArgs e)
        {
            // Get the entered hexadecimal color code
            string hexColor = txtColor6.Text.Trim();

            // Check if the entered value is a valid hexadecimal color code
            if (System.Text.RegularExpressions.Regex.IsMatch(hexColor, "^#(?:[0-9a-fA-F]{3}){1,2}$"))
            {
                // Convert the hexadecimal color to a Color object
                Color newColor = ColorTranslator.FromHtml(hexColor);

                // Set the BackColor of pic1 to the entered color
                pnl6.BackColor = newColor;

                // Find the closest named color to the entered color
                string colorName = "";
                foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
                {
                    Color namedColor = Color.FromKnownColor(knownColor);
                    if (namedColor.ToArgb() == newColor.ToArgb())
                    {
                        colorName = knownColor.ToString();
                        break;
                    }
                }

                // Display the closest named color in lblColor1
                lblColor6.Text = colorName != "" ? colorName : "Custom Color";
            }
            else
            {
                // If the entered value is not a valid hexadecimal color code
                lblColor6.Text = "Invalid Color";
            }
        }

        private void picSearchButton_Click(object sender, EventArgs e)
        {
            string userInput = txtSearch.Text.Trim().ToLower(); // Get user input in lowercase

            if (colorDictionary.ContainsKey(userInput))
            {
                // If the entered text matches a known color name in the dictionary
                string hexValue = colorDictionary[userInput];

                // Set the hex value in the appropriate TextBox (e.g., txtColor1)
                txtColor1.Text = hexValue;
                // You might need to trigger the TextChanged event for txtColor1 to update the color display
                // txtColor1_TextChanged(null, EventArgs.Empty);
            }
            else
            {
                // If the entered text doesn't match any known color name
                MessageBox.Show("Color not found. Please enter a valid color name.", "Color Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the 'ding' sound

                // Call the color search method when Enter key is pressed
                SearchColor();
            }
        }
        public void SearchColor()
        {
            string userInput = txtSearch.Text.Trim().ToLower();

            if (colorDictionary.ContainsKey(userInput))
            {
                string hexValue = colorDictionary[userInput];
                txtColor1.Text = hexValue;
                // You might need to trigger the TextChanged event for txtColor1 to update the color display
                // txtColor1_TextChanged(null, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Color not found. Please enter a valid color name.", "Color Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripDropDownButton1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show("eeeeeeehh");
        }

        private void ChangetoBalck_Click(object sender, EventArgs e)
        {
            this.Hide();
            black_form ss = new black_form();
            ss.Show();

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

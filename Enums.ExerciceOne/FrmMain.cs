using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Enums.ExerciceOne
{
    public partial class FrmMain : Form
    {
        private const string NOT_FOUND = "Not Found";
        private const string ARROW = " => ";
        enum Fruit
        {
            Apple = 4152,
            Banana = 4011,
            Orange,
            GreenGrapes = 4022,
            RedGrapes = 4023,
            Lime = 4048,
            Lemon = 4053,
            Watermelon = 4032,
            Pineapple = 4432,
            Kiwi = 4030
        }
        public FrmMain() => InitializeComponent();

        private void btnCodesToFruits_Click(object sender, EventArgs e)
        {
            //Storing NumericUpDowns' values in a list
            var nudCodeList = new List<int>
            {
                (int)nudCode1.Value,
                (int)nudCode2.Value,
                (int)nudCode3.Value,
                (int)nudCode4.Value,
                (int)nudCode5.Value
            };
            //If NumericUpDown value exists in enum Fruits, then return it in string type, else return "Not Found"
            string fruits = string.Empty;
            foreach (var item in nudCodeList)
                fruits += !Enum.IsDefined(typeof(Fruit), item) ? NOT_FOUND + Environment.NewLine :
                          ((Fruit)item).ToString() + Environment.NewLine;
            rtxFruits.Text = fruits.TrimEnd();
        }

        private void btnFruitsToCodes_Click(object sender, EventArgs e)
        {
            //Storing fruit names in string array "rtxStrings" while excluding "Not Found"
            lstFruitCodes.Items.Clear();
            string[] rtxStrings = rtxFruits.Text.Split('\n');
            if (rtxStrings.Contains(NOT_FOUND))
                rtxStrings = rtxStrings.Where(element => element != NOT_FOUND).ToArray();

            //If string value in "rtxStrings" exists in enum Fruits, then print in lstFruitCodes
            //for (int i = 0; i < rtxStrings.Length; i++)
            //    foreach (var item in Enum.GetValues(typeof(Fruit)))
            //        if (rtxStrings[i] == item.ToString())
            //            lstFruitCodes.Items.Add(rtxStrings[i] + ARROW + (int)item);

            for (int i = 0; i < rtxStrings.Length; i++)
                if (Enum.IsDefined(typeof(Fruit), rtxStrings[i]))
                    lstFruitCodes.Items.Add(rtxStrings[i] + ARROW + (int)Enum.Parse(typeof(Fruit), rtxStrings[i]));
        }
    }
}

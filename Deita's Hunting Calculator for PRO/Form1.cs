using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deita_s_Hunting_Calculator_for_PRO
{
    public partial class Form1 : Form
    {
        private string detailedResult = "";

        public Form1()
        {
            InitializeComponent();

            // Attach event handlers for input validation
            TB_Def.KeyPress += new KeyPressEventHandler(TB_Atk_KeyPress);
            TB_Def.Leave += new EventHandler(TB_Atk_Leave);
            TB_Spd.KeyPress += new KeyPressEventHandler(TB_Atk_KeyPress);
            TB_Spd.Leave += new EventHandler(TB_Atk_Leave);
            TB_Spatk.KeyPress += new KeyPressEventHandler(TB_Atk_KeyPress);
            TB_Spatk.Leave += new EventHandler(TB_Atk_Leave);
            TB_Spdef.KeyPress += new KeyPressEventHandler(TB_Atk_KeyPress);
            TB_Spdef.Leave += new EventHandler(TB_Atk_Leave);
            TB_HP.KeyPress += new KeyPressEventHandler(TB_Atk_KeyPress);
            TB_HP.Leave += new EventHandler(TB_Atk_Leave);
        }

        // Validate input to ensure it's a digit
        private void TB_Atk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Ensure IV values are within the range 1-31
        private void TB_Atk_Leave(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (int.TryParse(txtBox.Text, out int value))
            {
                if (value < 1)
                {
                    value = 1;
                }
                else if (value > 31)
                {
                    value = 31;
                }
                txtBox.Text = value.ToString();
            }
        }

        // Check if all input fields are filled
        private bool AreAllFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(TB_Atk.Text) &&
                   !string.IsNullOrWhiteSpace(TB_Def.Text) &&
                   !string.IsNullOrWhiteSpace(TB_Spatk.Text) &&
                   !string.IsNullOrWhiteSpace(TB_Spdef.Text) &&
                   !string.IsNullOrWhiteSpace(TB_Spd.Text) &&
                   !string.IsNullOrWhiteSpace(TB_HP.Text);
        }

        // Calculate probability for an individual IV
        private double CalculateProbability(int minIV, int maxIV)
        {
            return (maxIV - minIV + 1) / 31.0;
        }

        // Handle button click event to calculate and display results
        private void BTN_Calculate_Click(object sender, EventArgs e)
        {
            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Please enter IVs for all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int minAtk = int.Parse(TB_Atk.Text);
            int minDef = int.Parse(TB_Def.Text);
            int minSpatk = int.Parse(TB_Spatk.Text);
            int minSpdef = int.Parse(TB_Spdef.Text);
            int minSpd = int.Parse(TB_Spd.Text);
            int minHP = int.Parse(TB_HP.Text);

            double atkProb = CalculateProbability(minAtk, 31);
            double defProb = CalculateProbability(minDef, 31);
            double spatkProb = CalculateProbability(minSpatk, 31);
            double spdefProb = CalculateProbability(minSpdef, 31);
            double spdProb = CalculateProbability(minSpd, 31);
            double hpProb = CalculateProbability(minHP, 31);

            // Combine the probabilities by multiplying them
            double combinedProb = atkProb * defProb * spatkProb * spdefProb * spdProb * hpProb;

            // Calculate the expected number of Pokémon to catch
            double expectedPokemon = 1 / combinedProb;

            // Store detailed results
            detailedResult = $"\nProbability of ATK >= {minAtk}: {atkProb:P}\n" +
                             $"Probability of DEF >= {minDef}: {defProb:P}\n" +
                             $"Probability of SPATK >= {minSpatk}: {spatkProb:P}\n" +
                             $"Probability of SPDEF >= {minSpdef}: {spdefProb:P}\n" +
                             $"Probability of SPD >= {minSpd}: {spdProb:P}\n" +
                             $"Probability of HP >= {minHP}: {hpProb:P}\n" +
                             $"Combined Probability: {combinedProb:P}\n\n";

            RTB_Result.Text = $"Expected Number of Pokémon to Catch: {Math.Round(expectedPokemon):N0}\n";
        }

        // Handle the More Details button click event to display additional information
        private void BTN_MoreDetails_Click(object sender, EventArgs e)
        {
            RTB_Result.Text += detailedResult;
        }
    }
}

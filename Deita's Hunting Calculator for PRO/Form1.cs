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

        private bool isDetailedView = false;

        // Handle button click event to calculate and display results
        // Handle button click event to calculate and display results
        // Handle button click event to calculate and display results
        private void BTN_Calculate_Click(object sender, EventArgs e)
        {
            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Please enter IVs for all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse IV values from input fields
            int minAtk = int.Parse(TB_Atk.Text);
            int minDef = int.Parse(TB_Def.Text);
            int minSpatk = int.Parse(TB_Spatk.Text);
            int minSpdef = int.Parse(TB_Spdef.Text);
            int minSpd = int.Parse(TB_Spd.Text);
            int minHP = int.Parse(TB_HP.Text);
            int maxAtk = 31;

            // Calculate individual IV probabilities
            double atkProb = CalculateProbability(minAtk, maxAtk);
            double defProb = CalculateProbability(minDef, maxAtk);
            double spatkProb = CalculateProbability(minSpatk, maxAtk);
            double spdefProb = CalculateProbability(minSpdef, maxAtk);
            double spdProb = CalculateProbability(minSpd, maxAtk);
            double hpProb = CalculateProbability(minHP, maxAtk);

            // Combine the IV probabilities by multiplying them
            double combinedIVProb = atkProb * defProb * spatkProb * spdefProb * spdProb * hpProb;

            // Calculate Preferred Ability Probability based on CB_BMS and CB_Ability selections
            double hiddenAbilityChance = CB_BMS.SelectedItem.ToString() == "Yes" ? 0.25 : 0.05;
            double preferredAbilityProb;

            string selectedAbility = CB_Ability.SelectedItem.ToString();
            if (selectedAbility == "Primary Abilities Only")
            {
                preferredAbilityProb = 1 - hiddenAbilityChance;
            }
            else if (selectedAbility == "1/2 Primary Abilities")
            {
                preferredAbilityProb = (1 - hiddenAbilityChance) / 2;
            }
            else if (selectedAbility == "1/2 Primary Abilities + H.A.")
            {
                preferredAbilityProb = ((1 - hiddenAbilityChance) / 2) + hiddenAbilityChance;
            }
            else if (selectedAbility == "Hidden Ability Only")
            {
                preferredAbilityProb = hiddenAbilityChance;
            }
            else
            {
                preferredAbilityProb = 1; // Assuming "Any" or invalid selection
            }

            // Get the selected value from CB_Nature and adjust the probability
            string selectedNature = CB_Nature.SelectedItem.ToString();
            double natureProb;
            if (selectedNature == "Any")
            {
                natureProb = 1;
            }
            else
            {
                int natureValue = int.Parse(selectedNature);
                natureProb = 0.5 + (natureValue) / 25.0;
            }

            // Calculate Preferred Hidden Power Probability based on CB_HiddenPower selections
            double hiddenPowerProb;
            string selectedHiddenPower = CB_HiddenPower.SelectedItem.ToString();
            switch (selectedHiddenPower)
            {
                case "Fighting":
                    hiddenPowerProb = 0.078125;
                    break;
                case "Flying":
                case "Poison":
                case "Ground":
                case "Rock":
                case "Ghost":
                case "Steel":
                case "Fire":
                case "Water":
                case "Electric":
                case "Ice":
                case "Dragon":
                case "Psychic":
                    hiddenPowerProb = 0.0625;
                    break;
                case "Bug":
                case "Grass":
                    hiddenPowerProb = 0.078125;
                    break;
                case "Dark":
                    hiddenPowerProb = 0.015625;
                    break;
                case "Any":
                    hiddenPowerProb = 1;
                    break;
                default:
                    hiddenPowerProb = 1; // Default to 100% if "Any" or invalid selection
                    break;
            }
            // Calculate the total combined probability
            double totalCombinedProb = combinedIVProb * natureProb * preferredAbilityProb * hiddenPowerProb;

            // Calculate the expected number of Pokémon to catch
            storedExpectedPokemon = 1 / totalCombinedProb; // Store the value

            // Store detailed results
            detailedResult = $"Expected Number of Pokémon to Catch: {Math.Round(storedExpectedPokemon):N0}\n\n" +
                             $"Probability of ATK >= {minAtk}: {atkProb:P}\n" +
                             $"Probability of DEF >= {minDef}: {defProb:P}\n" +
                             $"Probability of SPATK >= {minSpatk}: {spatkProb:P}\n" +
                             $"Probability of SPDEF >= {minSpdef}: {spdefProb:P}\n" +
                             $"Probability of SPD >= {minSpd}: {spdProb:P}\n" +
                             $"Probability of HP >= {minHP}: {hpProb:P}\n\n" +
                             $"Combined IV Probability: {combinedIVProb:P6}\n" +
                             $"Preferred Ability Probability: {preferredAbilityProb:P}\n" +
                             $"Preferred Nature Probability: {natureProb:P}\n" +
                             $"Preferred Hidden Power Probability: {hiddenPowerProb:P}\n\n" +
                             $"Total Combined Probability: {totalCombinedProb:P10}\n\n";

            // Show the current view (simplified or detailed)
            if (isDetailedViewActive)
            {
                RTB_Result.Text = detailedResult;
                BTN_MoreDetails.Text = "Simplified";
            }
            else
            {
                RTB_Result.Text = $"Expected Number of Pokémon to Catch: {Math.Round(storedExpectedPokemon):N0}\n";
                BTN_MoreDetails.Text = "Detailed";
            }
            BTN_MoreDetails.Visible = true;
        }

        // Handle the More Details button click event to display additional information
        private void BTN_MoreDetails_Click(object sender, EventArgs e)
        {
            if (isDetailedViewActive)
            {
                // Show simplified view using the stored expectedPokemon value
                RTB_Result.Text = $"Expected Number of Pokémon to Catch: {Math.Round(storedExpectedPokemon):N0}\n";
                BTN_MoreDetails.Text = "Detailed";
                isDetailedViewActive = false;
            }
            else
            {
                // Show detailed view
                RTB_Result.Text = detailedResult;
                BTN_MoreDetails.Text = "Simplified";
                isDetailedViewActive = true;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CB_Ability.SelectedIndex = 0;
            CB_Nature.SelectedIndex = 0;
            CB_BMS.SelectedIndex = 0;
            CB_HiddenPower.SelectedIndex = 0;
        }
        private double storedExpectedPokemon;
        private bool isDetailedViewActive = false;
    }
}

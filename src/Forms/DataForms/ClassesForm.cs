using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TES3MP_GUI.src.Enums;
using TES3MP_GUI.src.Extra;
using TES3MP_GUI.src.Forms.DataForms;

namespace TES3MP_GUI.DataForms
{
    /*
     * 
     * Shows Major/Minor/Misc Skills,
     * Class Name, Class Description (If Applicable)
     * 
     */

    public partial class ClassesForm : Form
    {

        private string player;
        private Form parentForm;

        int[] skills = new int[27];

        Label[] majLabs, minLabs, miscLabs;
        string[] maj, min, misc;

        NumericUpDown[] majUds;
        NumericUpDown[] minUds;

        public ClassesForm(string player, Form parentForm)
        {

            InitializeComponent();

            this.player = player;
            this.parentForm = parentForm;

            classesTop.Text = player + "'s Class";
            classesTop.Left = (this.ClientSize.Width - classesTop.Width) / 2;

            maj = JsonInfo.GetMajorMinor(player, "major");
            min = JsonInfo.GetMajorMinor(player, "minor");
            misc = JsonInfo.GetMisc(player);

            majLabs = new Label[]
            {
                maj1, maj2, maj3, maj4, maj5
            };

            minLabs = new Label[]
            {
                min1, min2, min3, min4, min5
            };

            miscLabs = new Label[]
            {
                misc1, misc2, misc3, misc4, misc5, misc6, misc7, misc8, misc9, misc10, misc11, misc12, misc13, misc14, misc15, misc16, misc17
            };

            FixElements();
            MapValues();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReopenParent);
            this.CenterToScreen();
        }

        // Takes the array of all NumericUpDowns, and sets the array of values
        // into the player's JSON file. The array is set up automatically to be the order
        // of skills to be the same as the JSON file.
        private void applyChangesBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < majLabs.Length; i++)
            {
                string convSkill = majLabs[i].Text
                                        .Replace("-", "_")
                                        .Replace(" ", "_");
                System.Console.WriteLine("Major CV: " + convSkill);
                int index = (int)(SkillsInfo.Skills)Enum.Parse(typeof(SkillsInfo.Skills), convSkill);
                skills[index] = (int)majUds[i].Value;

                convSkill = minLabs[i].Text
                                .Replace("-", "_")
                                .Replace(" ", "_");
                System.Console.WriteLine("Minor CV: " + convSkill);
                index = (int)(SkillsInfo.Skills)Enum.Parse(typeof(SkillsInfo.Skills), convSkill);
                skills[index] = (int)minUds[i].Value;
            }

            for (int i = 0; i < miscLabs.Length; i++)
            {
                string convSkill = miscLabs[i].Text
                                        .Replace("-", "_")
                                        .Replace(" ", "_");
                System.Console.WriteLine("Misc CV: " + convSkill);
                int index = (int)(SkillsInfo.Skills)Enum.Parse(typeof(SkillsInfo.Skills), convSkill);
                skills[index] = (int)miscUds[i].Value;
            }

            // Debugging.PrintArray(skills);

            bool success = JsonInfo.EditSkills(player, skills);

            if (success)
                MessageBox.Show("Skills stats updated for " + player, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Unable to update skill stats for " + player + ". Please ensure server is setup properly.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void changeClassBtn_Click(object sender, EventArgs e)
        {
            ChooseClassForm ccf = new ChooseClassForm(player, this);

            try
            {
                ccf.Show();
            } catch (Exception)
            {

            }
        }

        NumericUpDown[] miscUds;

        

        private void FixElements()
        {
            classNameLabel.Top = classesTop.Top + classesTop.Height + 3;
            if (JsonInfo.IsCustomClass(player))
            {
                string[] nameAndDesc = JsonInfo.GetClassNameAndDesc(player);
                classNameLabel.Text = "Class Name: " + nameAndDesc[0];
                classNameLabel.Left = (this.ClientSize.Width - classNameLabel.Width) / 2;

                descLabel.Text = "Description: " + nameAndDesc[1];
                descLabel.Left = ((this.ClientSize.Width - descLabel.Width) / 2);
                descLabel.Top = classNameLabel.Top + classNameLabel.Height + 10;

                majorLabel.Left = (this.ClientSize.Width - majorLabel.Width) / 2;
                majorLabel.Top = descLabel.Top + descLabel.Height + 5;
            } else
            {
                classNameLabel.Text = "Class Name: " + JsonInfo.GetClassNameNotCustom(player);
                classNameLabel.Left = (this.ClientSize.Width - classNameLabel.Width) / 2;
                this.Controls.Remove(descLabel);
                majorLabel.Left = (this.ClientSize.Width - majorLabel.Width) / 2;
                majorLabel.Top = classNameLabel.Top + classNameLabel.Height + 3;
            }

            majUds = new NumericUpDown[] { majUd1, majUd2, majUd3, majUd4, majUd5 };
            minUds = new NumericUpDown[] { minUd1, minUd2, minUd3, minUd4, minUd5 };
            miscUds = new NumericUpDown[] { miscUd1, miscUd2, miscUd3, miscUd4, miscUd5, miscUd6, miscUd7, miscUd8, miscUd9, miscUd10, miscUd11, miscUd12, miscUd13, miscUd14, miscUd15, miscUd16, miscUd17 };

            majorTable.Top = majorLabel.Top + majorLabel.Height + 3;
            majorTable.Left = (this.ClientSize.Width - majorTable.Width) / 2;

            minorLabel.Top = majorTable.Top + majorTable.Height + 3;
            minorLabel.Left = (this.ClientSize.Width - minorLabel.Width) / 2;
            minorTable.Top = minorLabel.Top + minorLabel.Height + 3;
            minorTable.Left = (this.ClientSize.Width - minorTable.Width) / 2;

            miscLabel.Top = minorTable.Top + minorTable.Height + 3;
            miscLabel.Left = (this.ClientSize.Width - miscLabel.Width) / 2;
            miscTable.Top = miscLabel.Top + miscLabel.Height + 3;
            miscTable.Left = (this.ClientSize.Width - miscTable.Width) / 2;

            miscTable2.Top = miscTable.Top + miscTable.Height + 3;
            miscTable2.Left = (this.ClientSize.Width - miscTable2.Width) / 2;

        }


        // This uses the Enum from the SkillsInfo class. I found this
        // most efficient to make and pass the skills array.
        private void MapValues()
        {
            skills = JsonInfo.GetSkillData(player);

            for (int i = 0; i < majLabs.Length; i++)
            {
                majLabs[i].Text = maj[i];
                minLabs[i].Text = min[i];

                string skillName = majLabs[i].Text
                    .Replace(" ", "_")
                    .Replace("-", "_")
                    .Replace("Handtohand", "Hand_to_hand");
                int skillNum = (int)(SkillsInfo.Skills)Enum.Parse(typeof(SkillsInfo.Skills), skillName);

                skillName = skillName.Replace("Hand_to_hand", "Hand-to-hand");

                // System.Console.WriteLine("Major -> Skillname: " + skillName + ", Enum: " + skillNum);
                majUds[i].Value = skills[skillNum];

                majLabs[i].Text = majLabs[i].Text.Replace("_", " ")
                                                 .Replace("Handtohand", "Hand-to-hand");

                skillName = minLabs[i].Text
                    .Replace(" ", "_")
                    .Replace("-", "_")
                    .Replace("Handtohand", "Hand_to_hand");
                // System.Console.WriteLine("LOOKING FOR " + skillName);
                skillNum = (int)(SkillsInfo.Skills)Enum.Parse(typeof(SkillsInfo.Skills), skillName);

                skillName = skillName.Replace("Hand_to_hand", "Hand-to-hand");

                // System.Console.WriteLine("Minor -> Skillname: " + skillName + ", Enum: " + skillNum);
                minUds[i].Value = skills[skillNum];

                minLabs[i].Text = minLabs[i].Text.Replace("_", " ")
                                                 .Replace("Handtohand", "Hand-to-hand");
            }

            for (int i = 0; i < miscLabs.Length; i++)
            {
                miscLabs[i].Text = misc[i];

                string skillName = miscLabs[i].Text
                    .Replace(" ", "_")
                    .Replace("-", "_");
                int skillNum = (int)(SkillsInfo.Skills)Enum.Parse(typeof(SkillsInfo.Skills), skillName);

                skillName = skillName.Replace("Handtohand", "Hand-to-hand");

                System.Console.WriteLine("Misc -> Skillname: " + skillName + ", Enum: " + skillNum);
                miscUds[i].Value = skills[skillNum];
                miscLabs[i].Text = miscLabs[i].Text.Replace("_", " ")
                                                   .Replace("Handtohand", "Hand-to-hand");
            }


        }

        private void ReopenParent(object sender, EventArgs e)
        {
            parentForm.Show();
        }

    }
}

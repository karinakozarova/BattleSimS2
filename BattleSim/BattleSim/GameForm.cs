using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSim
{
    public partial class GameForm : Form
    {
        Game game;
        bool player1Turn = true;
        WizardControl wizardControl;
        KnightControl knightControl;
        WizardControl wizardControl1;
        KnightControl knightControl1;
        public GameForm(Game game)
        {
            InitializeComponent();
            this.game = game;
            PopulateControls();
        }

        public void PopulateControls()
        {
            Character character1 = this.game.Player1.SelectedCharacter;
            Character character2 = this.game.Player2.SelectedCharacter;
            if (character1 is Wizard)
            {
                this.wizardControl = new WizardControl(this.game.Player1);
                flpPlayer1.Controls.Add(wizardControl);
            }
            else if(character1 is Knight)
            {
                this.knightControl = new KnightControl(this.game.Player1);
                flpPlayer1.Controls.Add(knightControl);
            }
            if (character2 is Wizard)
            {
                this.wizardControl1 = new WizardControl(this.game.Player2);
                flpPlayer2.Controls.Add(wizardControl1);
            }
            else if (character2 is Knight)
            {
                this.knightControl1 = new KnightControl(this.game.Player2);
                flpPlayer2.Controls.Add(knightControl1);
            }

        }
        private void btnAttack_Click(object sender, EventArgs e)
        {
            Character character1 = this.game.Player1.SelectedCharacter;
            Character character2 = this.game.Player2.SelectedCharacter;
            int healthPlayer1 = (int)this.game.Player1.SelectedCharacter.Health;
            int healthPlayer2 = (int)this.game.Player2.SelectedCharacter.Health;
            int manaPlayer1;
            int manaPlayer2;
            if (player1Turn == true)
            {
                double damagePlayer1 = this.game.Player1.SelectedCharacter.DealDamage();
                if (character2 is Wizard)
                {
                    this.game.Player2.SelectedCharacter.ReceiveDamage(damagePlayer1);
                    healthPlayer2 = (int)this.game.Player2.SelectedCharacter.Health;
                    int mana = (int)((Wizard)this.game.Player2.SelectedCharacter).Mana;

                    if(character1 is Wizard)
                    {
                        lbxAttacksLog.Items.Add(((Wizard)this.game.Player1.SelectedCharacter).DamageToString(damagePlayer1));
                    }
                    else
                    {
                        lbxAttacksLog.Items.Add(((Knight)this.game.Player1.SelectedCharacter).DamageToString(damagePlayer1));
                    }
                    foreach (Control c in flpPlayer2.Controls)
                    {
                        if (c.GetType() == typeof(WizardControl))
                        {
                            if (healthPlayer2 <= 0)
                            {
                                this.game.EndGame();
                                string name = this.game.Player1.PlayerName;
                                this.wizardControl1.UpdateHealthGUI(0);
                                lbxAttacksLog.Items.Add($"{name} has won the game!");
                                MessageBox.Show($"Player {name} has won the game!");
                                btnAttack.Enabled = false;
                                return;
                            }
                            else
                            {
                                this.wizardControl1.UpdateHealthGUI(healthPlayer2);
                            }
                        }
                    }
                }
                else
                {
                    this.game.Player2.SelectedCharacter.ReceiveDamage(damagePlayer1);
                    healthPlayer2 = (int)this.game.Player2.SelectedCharacter.Health;
                    int shieldPower = (int)((Knight)this.game.Player2.SelectedCharacter).ShieldPower;

                    if (character1 is Wizard)
                    {
                        lbxAttacksLog.Items.Add(((Wizard)this.game.Player1.SelectedCharacter).DamageToString(damagePlayer1));
                    }
                    else
                    {
                        lbxAttacksLog.Items.Add(((Knight)this.game.Player1.SelectedCharacter).DamageToString(damagePlayer1));
                    }

                    foreach (Control c in flpPlayer2.Controls)
                    {
                        if (c.GetType() == typeof(KnightControl))
                        {
                            if (healthPlayer2 <= 0)
                            {
                                this.game.EndGame();
                                string name = this.game.Player1.PlayerName;
                                this.knightControl1.UpdateGUI(0, 0);
                                lbxAttacksLog.Items.Add($"{name} has won the game!");
                                MessageBox.Show($"Player {name} has won the game!");
                                btnAttack.Enabled = false;
                                return;
                            }
                            else
                            {
                                this.knightControl1.UpdateGUI(healthPlayer2, shieldPower);
                            }
                        }
                    }
                }
                if (character1 is Wizard)
                {
                    manaPlayer1 = (int)((Wizard)this.game.Player1.SelectedCharacter).Mana;
                    this.wizardControl.UpdateManaGUI(manaPlayer1);
                }
                player1Turn = false;
            }
            else if (player1Turn == false)
            {
                double damagePlayer2 = this.game.Player2.SelectedCharacter.DealDamage();
                if (character1 is Wizard)
                {
                    this.game.Player1.SelectedCharacter.ReceiveDamage(damagePlayer2);
                    healthPlayer1 = (int)this.game.Player1.SelectedCharacter.Health;
                    int mana = (int)((Wizard)this.game.Player1.SelectedCharacter).Mana;

                    if (character2 is Wizard)
                    {
                        lbxAttacksLog.Items.Add(((Wizard)this.game.Player2.SelectedCharacter).DamageToString(damagePlayer2));
                    }
                    else
                    {
                        lbxAttacksLog.Items.Add(((Knight)this.game.Player2.SelectedCharacter).DamageToString(damagePlayer2));
                    }

                    foreach (Control c in flpPlayer1.Controls)
                    {
                        if (c.GetType() == typeof(WizardControl))
                        {
                            if (healthPlayer1 <= 0)
                            {
                                this.game.EndGame();
                                string name = this.game.Player2.PlayerName;
                                this.wizardControl.UpdateHealthGUI(0);
                                lbxAttacksLog.Items.Add($"{name} has won the game!");
                                MessageBox.Show($"Player {name} has won the game!");
                                btnAttack.Enabled = false;
                                return;
                            }
                            else
                            {
                                this.wizardControl.UpdateHealthGUI(healthPlayer1);
                            }
                        }
                    }
                }
                else
                {
                    this.game.Player1.SelectedCharacter.ReceiveDamage(damagePlayer2);
                    healthPlayer1 = (int)this.game.Player1.SelectedCharacter.Health;
                    int shieldPower = (int)((Knight)this.game.Player1.SelectedCharacter).ShieldPower;

                    if (character2 is Wizard)
                    {
                        lbxAttacksLog.Items.Add(((Wizard)this.game.Player2.SelectedCharacter).DamageToString(damagePlayer2));
                    }
                    else
                    {
                        lbxAttacksLog.Items.Add(((Knight)this.game.Player2.SelectedCharacter).DamageToString(damagePlayer2));
                    }

                    foreach (Control c in flpPlayer1.Controls)
                    {
                        if (c.GetType() == typeof(KnightControl))
                        {
                            if (healthPlayer1 <= 0)
                            {
                                this.game.EndGame();
                                string name = this.game.Player2.PlayerName;
                                this.knightControl.UpdateGUI(0, 0);
                                lbxAttacksLog.Items.Add($"{name} has won the game!");
                                MessageBox.Show($"Player {name} has won the game!");
                                btnAttack.Enabled = false;
                                return;
                            }
                            else
                            {
                                this.knightControl.UpdateGUI(healthPlayer1, shieldPower);
                            }
                        }
                    }
                }
                if (character2 is Wizard)
                {
                    manaPlayer2 = (int)((Wizard)this.game.Player2.SelectedCharacter).Mana;
                    this.wizardControl1.UpdateManaGUI(manaPlayer2);
                }
                player1Turn = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nt_Injector.Properties;
using DiscordRpcDemo;
using System.Diagnostics;

namespace Cour_Csharp_pour_nt
{
    public partial class Form1 : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public Form1()
        {
            InitializeComponent();
            Commande.Text = "";
        }

        private void Debile_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Maximale";
            MessageBox.Show("Vous avez bien rendu bête Nt Games au niveau maximale", "Nt Injector 1.2 By : Toffelz");
            Debile.Enabled = false;
            Commande.Text = "Le niveau de débiliter de Nt Games est au niveau Maximale";
            pictureBox1.Image = Resources.Capture;
        }

        private void Spawn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Commande effectuer avec succés !","Nt Injector 1.2 By : Toffelz");
            Debile.Enabled = true;
            Despawn.Enabled = true;
            Spawn.Enabled = false;
            pictureBox1.Image = Resources.nt_games_normal;
            Commande.Text = "Nt Games a été spawn avec succés !";
            lblHelloWorld.Text = "Moyenne";
            endormir.Enabled = true;
            reveiller.Enabled = true;
            buttonrandom.Enabled = true;

        }

        private void Despawn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Commande effectuer avec succés !", "Nt Injector 1.2 By : Toffelz");
            Debile.Enabled = false;
            Despawn.Enabled = false;
            Spawn.Enabled = true;
            Commande.Text = "Nt Games a été despawn avec succés !";
            lblHelloWorld.Text = "Inconnu";
            reveiller.Enabled = false;
            endormir.Enabled = false;
            StatutNt2.Text = "Inconnu";
            pictureBox1.Image = null;
            buttonrandom.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("872513064325513246", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("872513064325513246", ref this.handlers, true, null);
            this.presence.details = "Nt Injector By : Toffelz";
            this.presence.state = "Thanks to Nt Games !";
            this.presence.largeImageKey = "logo_nt_injector";
            this.presence.smallImageKey = "versionlogo";
            this.presence.largeImageText = "Nt Injector";
            this.presence.smallImageText = "Version : 1.2";
            DiscordRpc.UpdatePresence(ref this.presence);
        }
        private void endormir_Click(object sender, EventArgs e)
        {
            Commande.Text = "Vous avez endormie Nt Games !";
            endormir.Enabled = false;
            MessageBox.Show("Vous avez endormie Nt Games !", "Nt Injector 1.2 By : Toffelz");
            StatutNt2.Text = "Endormie";
            reveiller.Enabled = true;
            pictureBox1.Image = Resources.fonction_endormir_nt;
        }

        private void reveiller_Click(object sender, EventArgs e)
        {
            Commande.Text = "Vous avez reveiller Nt Games !";
            reveiller.Enabled = false;
            endormir.Enabled = true;
            MessageBox.Show("Vous avez reveiller Nt Games !", "Nt Injector 1.2 By : Toffelz");
            StatutNt2.Text = "Reveiller";
            pictureBox1.Image = Resources.nt_games_normal;

        }

        private void bouttonrandom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shoji la grosse merde !", "Nt Injector 1.2 By : Toffelz");
        }

      
        private void PatchNote_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Patch note Mise à Jour 1.2" + "\n" + "-Ajout de l'onglet Paramètre" + "\n" + "-Ajout de Credit" + "\n" + "-Ajout d'une checkbox permettant de désactiver le chat" + "\n" + "-Ajout d'un bouton Random" + "\n" + 
                "-Ajout de bouton qui ramène au chaine Ytb de Toffelz et Nt Games", "Nt Injector 1.2 By : Toffelz");
        }

        private void Disable_CheckedChanged(object sender, EventArgs e)
        {
            if (Disable.Checked)
            {
                Commande.Visible = false;

            }
            else
            {
                Commande.Visible = true;
            }
        }

        private void ToffelzYtb_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UChB7vhqp5cNOfJ34f4K-0Mg");
        }

        private void NtYtb_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCqI3x47OlUfndU3b9VhAwwQ");
        }

        private void BouttonYoussef_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Youssef le bg" , "Nt Injector 1.2 By : Toffelz");
        }
    }
}

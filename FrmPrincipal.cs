using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoLL.View;


namespace ProjetoLL.View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void projetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProjetoCad proj = new FrmProjetoCad();
            proj.Show();
        }

        private void sprintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSprint sprint = new FrmSprint();
            sprint.Show();
        }

        private void liçõesAprendidasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 la = new Form1();
            la.Show();

  

        }

        private void featureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFeature feature = new FrmFeature();
            feature.Show();
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProjeto pesqProj = new FrmProjeto();
            pesqProj.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

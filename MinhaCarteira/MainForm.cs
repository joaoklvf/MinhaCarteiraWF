using Microsoft.EntityFrameworkCore;
using MinhaCarteira.Data;
using MinhaCarteira.Models;
using System.ComponentModel;

namespace MinhaCarteira
{
    public partial class MainForm : Form
    {
        private ProductsContext? dbContext;

        public MainForm()
        {
            InitializeComponent();
            StartComponent();
        }

        private void StartComponent()
        {
            DefinirHoraAtual();
            this.timer1.Start();
        }

        private void DefinirHoraAtual() => 
            this.txtCurrentTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        private void timer1_Tick(object sender, EventArgs e) 
            => DefinirHoraAtual();
    }
}

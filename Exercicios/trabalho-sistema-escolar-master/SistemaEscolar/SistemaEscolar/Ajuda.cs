﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar
{
    public partial class Ajuda : Form
    {
        public Ajuda()
        {
            InitializeComponent();
        }

        private void btn_RecuperarSenha_Click(object sender, EventArgs e)
        {
            AjudaRecuperarSenha recuperaSenha = new AjudaRecuperarSenha();
            recuperaSenha.ShowDialog();
        }

        private void btn_SugestaoBug_Click(object sender, EventArgs e)
        {
            SugestaoBug enviarSugestaoBug = new SugestaoBug();
            enviarSugestaoBug.ShowDialog();
        }
        

        
    }
}

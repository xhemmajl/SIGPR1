﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VigenereCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnkripto_Click(object sender, EventArgs e)
        {
            string plaintexti = txtPlaintexti.Text;
            string celesi = txtCelesi.Text;
            lblrezultati.Text = Enkripto(plaintexti, celesi);
        }
        private string Enkripto(string plaintexti, string celesi)
        {
            string ciphertexti = "";
            char[] keys = celesi.ToCharArray();
            int x = 0;
            for (int i = 0; i < plaintexti.Length; i++)
            {
                int p = plaintexti[i] - 97;
                int k = keys[x] - 97;
                ciphertexti += Convert.ToChar(((p + k) % 26) + 97);
                x = (x + 1) % celesi.Length;
            }
            return ciphertexti;
        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            string ciphertexti = lblrezultati.Text;
            string celesi = txtCelesi.Text;
            lblrezultati.Text = Dekripto(ciphertexti, celesi);
        }
        private string Dekripto(string ciphertexti, string celesi)
        {

            int cunt = 0;
            string decryption = "";
            char[] keys = celesi.ToCharArray();
            for (int i = 0; i < ciphertexti.Length; i++)
            {
                int c = ciphertexti[i] - 97;
                int k = celesi[cunt] - 97;
                decryption += Convert.ToChar(((c - k + 26) % 26) + 97);
                cunt = (cunt + 1) % keys.Length;
            }
            return decryption;
        }
    }
}

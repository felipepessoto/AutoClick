namespace AutoClick
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tempo = new System.Windows.Forms.TextBox();
            this.intervalo = new System.Windows.Forms.Label();
            this.iniciar = new System.Windows.Forms.Button();
            this.avisoParar = new System.Windows.Forms.Label();
            this.modoLivre = new System.Windows.Forms.RadioButton();
            this.modoTravado = new System.Windows.Forms.RadioButton();
            this.campoX = new System.Windows.Forms.TextBox();
            this.campoY = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.quantCliques = new System.Windows.Forms.Label();
            this.cliques = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botDir = new System.Windows.Forms.RadioButton();
            this.botEsq = new System.Windows.Forms.RadioButton();
            this.timerBotao = new System.Windows.Forms.Timer(this.components);
            this.shakeBox = new System.Windows.Forms.CheckBox();
            this.ctrlBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempo
            // 
            this.tempo.Location = new System.Drawing.Point(107, 6);
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(100, 20);
            this.tempo.TabIndex = 0;
            this.tempo.Text = "1000";
            // 
            // intervalo
            // 
            this.intervalo.AutoSize = true;
            this.intervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalo.Location = new System.Drawing.Point(12, 9);
            this.intervalo.Name = "intervalo";
            this.intervalo.Size = new System.Drawing.Size(89, 13);
            this.intervalo.TabIndex = 1;
            this.intervalo.Text = "Intervalo(Miliseg):";
            // 
            // iniciar
            // 
            this.iniciar.Location = new System.Drawing.Point(12, 156);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(75, 23);
            this.iniciar.TabIndex = 6;
            this.iniciar.Text = "Iniciar";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // avisoParar
            // 
            this.avisoParar.AutoSize = true;
            this.avisoParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avisoParar.Location = new System.Drawing.Point(93, 155);
            this.avisoParar.Name = "avisoParar";
            this.avisoParar.Size = new System.Drawing.Size(118, 15);
            this.avisoParar.TabIndex = 3;
            this.avisoParar.Text = "(Caps Lock p/ Parar)";
            // 
            // modoLivre
            // 
            this.modoLivre.AutoSize = true;
            this.modoLivre.Checked = true;
            this.modoLivre.Location = new System.Drawing.Point(12, 27);
            this.modoLivre.Name = "modoLivre";
            this.modoLivre.Size = new System.Drawing.Size(78, 17);
            this.modoLivre.TabIndex = 1;
            this.modoLivre.TabStop = true;
            this.modoLivre.Text = "Modo Livre";
            this.modoLivre.UseVisualStyleBackColor = true;
            // 
            // modoTravado
            // 
            this.modoTravado.AutoSize = true;
            this.modoTravado.Location = new System.Drawing.Point(12, 50);
            this.modoTravado.Name = "modoTravado";
            this.modoTravado.Size = new System.Drawing.Size(121, 17);
            this.modoTravado.TabIndex = 2;
            this.modoTravado.Text = "Modo Travado(X, Y)";
            this.modoTravado.UseVisualStyleBackColor = true;
            this.modoTravado.CheckedChanged += new System.EventHandler(this.modoTravado_CheckedChanged);
            // 
            // campoX
            // 
            this.campoX.Enabled = false;
            this.campoX.Location = new System.Drawing.Point(35, 80);
            this.campoX.Name = "campoX";
            this.campoX.Size = new System.Drawing.Size(35, 20);
            this.campoX.TabIndex = 3;
            this.campoX.Text = "0";
            // 
            // campoY
            // 
            this.campoY.Enabled = false;
            this.campoY.Location = new System.Drawing.Point(35, 100);
            this.campoY.Name = "campoY";
            this.campoY.Size = new System.Drawing.Size(35, 20);
            this.campoY.TabIndex = 4;
            this.campoY.Text = "0";
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(12, 83);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(17, 13);
            this.x.TabIndex = 8;
            this.x.Text = "X:";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Location = new System.Drawing.Point(12, 103);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(17, 13);
            this.y.TabIndex = 9;
            this.y.Text = "Y:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // quantCliques
            // 
            this.quantCliques.Location = new System.Drawing.Point(-71, 129);
            this.quantCliques.Name = "quantCliques";
            this.quantCliques.Size = new System.Drawing.Size(100, 13);
            this.quantCliques.TabIndex = 10;
            this.quantCliques.Text = "0";
            this.quantCliques.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cliques
            // 
            this.cliques.AutoSize = true;
            this.cliques.Location = new System.Drawing.Point(35, 129);
            this.cliques.Name = "cliques";
            this.cliques.Size = new System.Drawing.Size(41, 13);
            this.cliques.TabIndex = 11;
            this.cliques.Text = "Cliques";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botDir);
            this.panel1.Controls.Add(this.botEsq);
            this.panel1.Location = new System.Drawing.Point(139, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 51);
            this.panel1.TabIndex = 14;
            // 
            // botDir
            // 
            this.botDir.AutoSize = true;
            this.botDir.Location = new System.Drawing.Point(0, 22);
            this.botDir.Name = "botDir";
            this.botDir.Size = new System.Drawing.Size(86, 17);
            this.botDir.TabIndex = 15;
            this.botDir.Text = "Botão Direito";
            this.botDir.UseVisualStyleBackColor = true;
            this.botDir.CheckedChanged += new System.EventHandler(this.botDir_CheckedChanged);
            // 
            // botEsq
            // 
            this.botEsq.AutoSize = true;
            this.botEsq.Checked = true;
            this.botEsq.Location = new System.Drawing.Point(0, 3);
            this.botEsq.Name = "botEsq";
            this.botEsq.Size = new System.Drawing.Size(98, 17);
            this.botEsq.TabIndex = 14;
            this.botEsq.TabStop = true;
            this.botEsq.Text = "Botão Esquedo";
            this.botEsq.UseVisualStyleBackColor = true;
            // 
            // timerBotao
            // 
            this.timerBotao.Interval = 1000;
            this.timerBotao.Tick += new System.EventHandler(this.timerBotao_Tick);
            // 
            // shakeBox
            // 
            this.shakeBox.AutoSize = true;
            this.shakeBox.Location = new System.Drawing.Point(139, 84);
            this.shakeBox.Name = "shakeBox";
            this.shakeBox.Size = new System.Drawing.Size(94, 17);
            this.shakeBox.TabIndex = 0;
            this.shakeBox.Text = "Tremer Mouse";
            this.shakeBox.UseVisualStyleBackColor = true;
            // 
            // ctrlBox
            // 
            this.ctrlBox.AutoSize = true;
            this.ctrlBox.Location = new System.Drawing.Point(139, 107);
            this.ctrlBox.Name = "ctrlBox";
            this.ctrlBox.Size = new System.Drawing.Size(99, 17);
            this.ctrlBox.TabIndex = 15;
            this.ctrlBox.Text = "Segurar Control";
            this.ctrlBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 191);
            this.Controls.Add(this.ctrlBox);
            this.Controls.Add(this.shakeBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cliques);
            this.Controls.Add(this.quantCliques);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.campoY);
            this.Controls.Add(this.campoX);
            this.Controls.Add(this.modoTravado);
            this.Controls.Add(this.modoLivre);
            this.Controls.Add(this.avisoParar);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.intervalo);
            this.Controls.Add(this.tempo);
            this.Name = "Form1";
            this.Text = "Fujiy Auto Clicker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tempo;
        private System.Windows.Forms.Label intervalo;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Label avisoParar;
        private System.Windows.Forms.RadioButton modoLivre;
        private System.Windows.Forms.RadioButton modoTravado;
        private System.Windows.Forms.TextBox campoX;
        private System.Windows.Forms.TextBox campoY;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label quantCliques;
        private System.Windows.Forms.Label cliques;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton botDir;
        private System.Windows.Forms.RadioButton botEsq;
        private System.Windows.Forms.Timer timerBotao;
        private System.Windows.Forms.CheckBox shakeBox;
        private System.Windows.Forms.CheckBox ctrlBox;
    }
}


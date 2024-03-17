
namespace AmbienteTransfGeometricas
{
    partial class tela
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.painel = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtYmax = new System.Windows.Forms.TextBox();
            this.txtXmax = new System.Windows.Forms.TextBox();
            this.txtYmin = new System.Windows.Forms.TextBox();
            this.txtXmin = new System.Windows.Forms.TextBox();
            this.lbYmax = new System.Windows.Forms.Label();
            this.lbXmax = new System.Windows.Forms.Label();
            this.lbYmin = new System.Windows.Forms.Label();
            this.lbXmin = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.Bresenham = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.lbY2 = new System.Windows.Forms.Label();
            this.lbX2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.btCor = new System.Windows.Forms.Button();
            this.btDesenhar = new System.Windows.Forms.Button();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.lbY1 = new System.Windows.Forms.Label();
            this.lbX1 = new System.Windows.Forms.Label();
            this.imagem = new System.Windows.Forms.PictureBox();
            this.cdlg = new System.Windows.Forms.ColorDialog();
            this.painel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // painel
            // 
            this.painel.BackColor = System.Drawing.SystemColors.Desktop;
            this.painel.Controls.Add(this.button8);
            this.painel.Controls.Add(this.button7);
            this.painel.Controls.Add(this.txtYmax);
            this.painel.Controls.Add(this.txtXmax);
            this.painel.Controls.Add(this.txtYmin);
            this.painel.Controls.Add(this.txtXmin);
            this.painel.Controls.Add(this.lbYmax);
            this.painel.Controls.Add(this.lbXmax);
            this.painel.Controls.Add(this.lbYmin);
            this.painel.Controls.Add(this.lbXmin);
            this.painel.Controls.Add(this.button6);
            this.painel.Controls.Add(this.Bresenham);
            this.painel.Controls.Add(this.button5);
            this.painel.Controls.Add(this.txtY2);
            this.painel.Controls.Add(this.txtX2);
            this.painel.Controls.Add(this.lbY2);
            this.painel.Controls.Add(this.lbX2);
            this.painel.Controls.Add(this.button4);
            this.painel.Controls.Add(this.button3);
            this.painel.Controls.Add(this.button2);
            this.painel.Controls.Add(this.button1);
            this.painel.Controls.Add(this.btApagar);
            this.painel.Controls.Add(this.btCor);
            this.painel.Controls.Add(this.btDesenhar);
            this.painel.Controls.Add(this.txtY1);
            this.painel.Controls.Add(this.txtX1);
            this.painel.Controls.Add(this.lbY1);
            this.painel.Controls.Add(this.lbX1);
            this.painel.Dock = System.Windows.Forms.DockStyle.Right;
            this.painel.Location = new System.Drawing.Point(575, 0);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(225, 450);
            this.painel.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button8.FlatAppearance.BorderSize = 3;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(13, 262);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 34);
            this.button8.TabIndex = 31;
            this.button8.Text = "Liang";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Liang_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button7.FlatAppearance.BorderSize = 3;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(121, 262);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 34);
            this.button7.TabIndex = 30;
            this.button7.Text = "Cohen";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btCohen_Click);
            // 
            // txtYmax
            // 
            this.txtYmax.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYmax.Location = new System.Drawing.Point(121, 144);
            this.txtYmax.Margin = new System.Windows.Forms.Padding(2);
            this.txtYmax.Name = "txtYmax";
            this.txtYmax.Size = new System.Drawing.Size(93, 29);
            this.txtYmax.TabIndex = 29;
            this.txtYmax.Text = "0";
            this.txtYmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtXmax
            // 
            this.txtXmax.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXmax.Location = new System.Drawing.Point(14, 144);
            this.txtXmax.Margin = new System.Windows.Forms.Padding(2);
            this.txtXmax.Name = "txtXmax";
            this.txtXmax.Size = new System.Drawing.Size(98, 29);
            this.txtXmax.TabIndex = 28;
            this.txtXmax.Text = "0";
            this.txtXmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYmin
            // 
            this.txtYmin.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYmin.Location = new System.Drawing.Point(121, 88);
            this.txtYmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtYmin.Name = "txtYmin";
            this.txtYmin.Size = new System.Drawing.Size(93, 29);
            this.txtYmin.TabIndex = 27;
            this.txtYmin.Text = "0";
            this.txtYmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtXmin
            // 
            this.txtXmin.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXmin.Location = new System.Drawing.Point(13, 88);
            this.txtXmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtXmin.Name = "txtXmin";
            this.txtXmin.Size = new System.Drawing.Size(99, 29);
            this.txtXmin.TabIndex = 26;
            this.txtXmin.Text = "0";
            this.txtXmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbYmax
            // 
            this.lbYmax.BackColor = System.Drawing.Color.Red;
            this.lbYmax.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYmax.Location = new System.Drawing.Point(122, 118);
            this.lbYmax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbYmax.Name = "lbYmax";
            this.lbYmax.Size = new System.Drawing.Size(92, 24);
            this.lbYmax.TabIndex = 25;
            this.lbYmax.Text = "Ymax";
            this.lbYmax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbXmax
            // 
            this.lbXmax.BackColor = System.Drawing.Color.Red;
            this.lbXmax.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXmax.Location = new System.Drawing.Point(14, 118);
            this.lbXmax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbXmax.Name = "lbXmax";
            this.lbXmax.Size = new System.Drawing.Size(98, 24);
            this.lbXmax.TabIndex = 24;
            this.lbXmax.Text = "Xmax";
            this.lbXmax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbYmin
            // 
            this.lbYmin.BackColor = System.Drawing.Color.Red;
            this.lbYmin.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYmin.Location = new System.Drawing.Point(122, 62);
            this.lbYmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbYmin.Name = "lbYmin";
            this.lbYmin.Size = new System.Drawing.Size(92, 24);
            this.lbYmin.TabIndex = 23;
            this.lbYmin.Text = "Ymin";
            this.lbYmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbXmin
            // 
            this.lbXmin.BackColor = System.Drawing.Color.Red;
            this.lbXmin.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXmin.Location = new System.Drawing.Point(14, 62);
            this.lbXmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbXmin.Name = "lbXmin";
            this.lbXmin.Size = new System.Drawing.Size(98, 24);
            this.lbXmin.TabIndex = 22;
            this.lbXmin.Text = "Xmin";
            this.lbXmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(121, 178);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 36);
            this.button6.TabIndex = 17;
            this.button6.Text = "Circulo";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btCirculo_Click);
            // 
            // Bresenham
            // 
            this.Bresenham.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Bresenham.FlatAppearance.BorderSize = 3;
            this.Bresenham.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Bresenham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Bresenham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bresenham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bresenham.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bresenham.Location = new System.Drawing.Point(13, 302);
            this.Bresenham.Name = "Bresenham";
            this.Bresenham.Size = new System.Drawing.Size(101, 36);
            this.Bresenham.TabIndex = 16;
            this.Bresenham.Text = "Bresenham";
            this.Bresenham.UseVisualStyleBackColor = true;
            this.Bresenham.Click += new System.EventHandler(this.btBress_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(14, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 36);
            this.button5.TabIndex = 15;
            this.button5.Text = "Escala -";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.escalaDown);
            // 
            // txtY2
            // 
            this.txtY2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY2.Location = new System.Drawing.Point(174, 28);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(48, 31);
            this.txtY2.TabIndex = 14;
            this.txtY2.Text = "0";
            this.txtY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtX2
            // 
            this.txtX2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX2.Location = new System.Drawing.Point(120, 28);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(48, 31);
            this.txtX2.TabIndex = 13;
            this.txtX2.Text = "0";
            this.txtX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbY2
            // 
            this.lbY2.BackColor = System.Drawing.Color.Red;
            this.lbY2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbY2.Location = new System.Drawing.Point(174, 0);
            this.lbY2.Name = "lbY2";
            this.lbY2.Size = new System.Drawing.Size(48, 25);
            this.lbY2.TabIndex = 12;
            this.lbY2.Text = "Y2";
            this.lbY2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbX2
            // 
            this.lbX2.BackColor = System.Drawing.Color.Red;
            this.lbX2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX2.Location = new System.Drawing.Point(120, 0);
            this.lbX2.Name = "lbX2";
            this.lbX2.Size = new System.Drawing.Size(48, 25);
            this.lbX2.TabIndex = 11;
            this.lbX2.Text = "X2";
            this.lbX2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(14, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 36);
            this.button4.TabIndex = 10;
            this.button4.Text = "Translação";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.translacao);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(120, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "Reflexão";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.reflexao);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(121, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Escala +";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.escala);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(121, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Rotação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.rotacao);
            // 
            // btApagar
            // 
            this.btApagar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btApagar.FlatAppearance.BorderSize = 3;
            this.btApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btApagar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApagar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btApagar.Location = new System.Drawing.Point(121, 220);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(92, 36);
            this.btApagar.TabIndex = 6;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btCor
            // 
            this.btCor.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btCor.FlatAppearance.BorderSize = 3;
            this.btCor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btCor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCor.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCor.Location = new System.Drawing.Point(13, 220);
            this.btCor.Name = "btCor";
            this.btCor.Size = new System.Drawing.Size(102, 36);
            this.btCor.TabIndex = 5;
            this.btCor.Text = "Cor";
            this.btCor.UseVisualStyleBackColor = true;
            this.btCor.Click += new System.EventHandler(this.btCor_Click);
            // 
            // btDesenhar
            // 
            this.btDesenhar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btDesenhar.FlatAppearance.BorderSize = 3;
            this.btDesenhar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btDesenhar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btDesenhar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDesenhar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesenhar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btDesenhar.Location = new System.Drawing.Point(13, 178);
            this.btDesenhar.Name = "btDesenhar";
            this.btDesenhar.Size = new System.Drawing.Size(102, 36);
            this.btDesenhar.TabIndex = 4;
            this.btDesenhar.Text = "DDA";
            this.btDesenhar.UseVisualStyleBackColor = true;
            this.btDesenhar.Click += new System.EventHandler(this.drawLineAtiv1);
            // 
            // txtY1
            // 
            this.txtY1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY1.Location = new System.Drawing.Point(62, 28);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(54, 31);
            this.txtY1.TabIndex = 3;
            this.txtY1.Text = "0";
            this.txtY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtY1.TextChanged += new System.EventHandler(this.txtY1_TextChanged);
            // 
            // txtX1
            // 
            this.txtX1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX1.Location = new System.Drawing.Point(6, 28);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(52, 31);
            this.txtX1.TabIndex = 2;
            this.txtX1.Text = "0";
            this.txtX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbY1
            // 
            this.lbY1.BackColor = System.Drawing.Color.Red;
            this.lbY1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbY1.Location = new System.Drawing.Point(63, 0);
            this.lbY1.Name = "lbY1";
            this.lbY1.Size = new System.Drawing.Size(53, 25);
            this.lbY1.TabIndex = 1;
            this.lbY1.Text = "Y1";
            this.lbY1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbX1
            // 
            this.lbX1.BackColor = System.Drawing.Color.Red;
            this.lbX1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX1.Location = new System.Drawing.Point(6, 0);
            this.lbX1.Name = "lbX1";
            this.lbX1.Size = new System.Drawing.Size(51, 25);
            this.lbX1.TabIndex = 0;
            this.lbX1.Text = "X1";
            this.lbX1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imagem
            // 
            this.imagem.BackColor = System.Drawing.Color.White;
            this.imagem.BackgroundImage = global::AmbienteTransfGeometricas.Properties.Resources.png_clipart_white_and_gray_frame_eastern_idaho_state_fair_whiteboard_magnet_open_high_low_close_chart_template_certificate_angle_white;
            this.imagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagem.Location = new System.Drawing.Point(0, 0);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(575, 450);
            this.imagem.TabIndex = 1;
            this.imagem.TabStop = false;
            this.imagem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imagem_MouseClick);
            this.imagem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imagem_MouseMove);
            // 
            // tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imagem);
            this.Controls.Add(this.painel);
            this.Name = "tela";
            this.Text = "Roteiro 3 – Algoritmo Bresenham";
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label lbY1;
        private System.Windows.Forms.Label lbX1;
        private System.Windows.Forms.PictureBox imagem;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btCor;
        private System.Windows.Forms.Button btDesenhar;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.ColorDialog cdlg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label lbY2;
        private System.Windows.Forms.Label lbX2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Bresenham;
        private System.Windows.Forms.TextBox txtYmax;
        private System.Windows.Forms.TextBox txtXmax;
        private System.Windows.Forms.TextBox txtYmin;
        private System.Windows.Forms.TextBox txtXmin;
        private System.Windows.Forms.Label lbYmax;
        private System.Windows.Forms.Label lbXmax;
        private System.Windows.Forms.Label lbYmin;
        private System.Windows.Forms.Label lbXmin;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}


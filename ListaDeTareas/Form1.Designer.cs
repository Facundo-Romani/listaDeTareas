namespace ListaDeTareas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.checkEntrenar = new System.Windows.Forms.CheckBox();
            this.checkEstudiar = new System.Windows.Forms.CheckBox();
            this.checkCompras = new System.Windows.Forms.CheckBox();
            this.checkLavar = new System.Windows.Forms.CheckBox();
            this.checkYoga = new System.Windows.Forms.CheckBox();
            this.checkPerro = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(94, 591);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(588, 389);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // checkEntrenar
            // 
            this.checkEntrenar.AutoSize = true;
            this.checkEntrenar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkEntrenar.Location = new System.Drawing.Point(110, 105);
            this.checkEntrenar.Name = "checkEntrenar";
            this.checkEntrenar.Size = new System.Drawing.Size(123, 24);
            this.checkEntrenar.TabIndex = 2;
            this.checkEntrenar.Text = "ENTRENAR";
            this.checkEntrenar.UseVisualStyleBackColor = true;
            // 
            // checkEstudiar
            // 
            this.checkEstudiar.AutoSize = true;
            this.checkEstudiar.Location = new System.Drawing.Point(110, 183);
            this.checkEstudiar.Name = "checkEstudiar";
            this.checkEstudiar.Size = new System.Drawing.Size(118, 24);
            this.checkEstudiar.TabIndex = 3;
            this.checkEstudiar.Text = "ESTUDIAR";
            this.checkEstudiar.UseVisualStyleBackColor = true;
            // 
            // checkCompras
            // 
            this.checkCompras.AutoSize = true;
            this.checkCompras.Location = new System.Drawing.Point(110, 263);
            this.checkCompras.Name = "checkCompras";
            this.checkCompras.Size = new System.Drawing.Size(211, 24);
            this.checkCompras.TabIndex = 4;
            this.checkCompras.Text = "HACER LAS COMPRAS";
            this.checkCompras.UseVisualStyleBackColor = true;
            // 
            // checkLavar
            // 
            this.checkLavar.AutoSize = true;
            this.checkLavar.Location = new System.Drawing.Point(110, 336);
            this.checkLavar.Name = "checkLavar";
            this.checkLavar.Size = new System.Drawing.Size(162, 24);
            this.checkLavar.TabIndex = 5;
            this.checkLavar.Text = "LAVAR LA ROPA";
            this.checkLavar.UseVisualStyleBackColor = true;
            // 
            // checkYoga
            // 
            this.checkYoga.AutoSize = true;
            this.checkYoga.Location = new System.Drawing.Point(110, 416);
            this.checkYoga.Name = "checkYoga";
            this.checkYoga.Size = new System.Drawing.Size(177, 24);
            this.checkYoga.TabIndex = 6;
            this.checkYoga.Text = "CLASES DE YOGA";
            this.checkYoga.UseVisualStyleBackColor = true;
            // 
            // checkPerro
            // 
            this.checkPerro.AutoSize = true;
            this.checkPerro.Location = new System.Drawing.Point(110, 495);
            this.checkPerro.Name = "checkPerro";
            this.checkPerro.Size = new System.Drawing.Size(196, 24);
            this.checkPerro.TabIndex = 7;
            this.checkPerro.Text = "COMIDA DEL PERRO";
            this.checkPerro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "TAREAS DIARIAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = global::ListaDeTareas.Properties.Resources.índice;
            this.pictureBox1.Location = new System.Drawing.Point(391, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 302);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 996);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "FINALIZADAS";
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Green;
            this.btnOk.Location = new System.Drawing.Point(434, 453);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(248, 53);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "AGREGAR A LISTA ";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(434, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 53);
            this.button1.TabIndex = 12;
            this.button1.Text = "LIMPIAR LISTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(764, 1044);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkPerro);
            this.Controls.Add(this.checkYoga);
            this.Controls.Add(this.checkLavar);
            this.Controls.Add(this.checkCompras);
            this.Controls.Add(this.checkEstudiar);
            this.Controls.Add(this.checkEntrenar);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox checkEntrenar;
        private System.Windows.Forms.CheckBox checkEstudiar;
        private System.Windows.Forms.CheckBox checkCompras;
        private System.Windows.Forms.CheckBox checkLavar;
        private System.Windows.Forms.CheckBox checkYoga;
        private System.Windows.Forms.CheckBox checkPerro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button1;
    }
}


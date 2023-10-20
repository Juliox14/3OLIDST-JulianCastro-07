namespace _3OLIDST_JulianCastro_07
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgFocoApagado = new System.Windows.Forms.PictureBox();
            this.imgFocoEncendido = new System.Windows.Forms.PictureBox();
            this.btnApagado = new System.Windows.Forms.Button();
            this.btnEncendido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgFocoApagado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFocoEncendido)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFocoApagado
            // 
            this.imgFocoApagado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgFocoApagado.BackgroundImage = global::_3OLIDST_JulianCastro_07.Properties.Resources.FocoApagado;
            this.imgFocoApagado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgFocoApagado.Location = new System.Drawing.Point(346, 164);
            this.imgFocoApagado.Name = "imgFocoApagado";
            this.imgFocoApagado.Size = new System.Drawing.Size(77, 79);
            this.imgFocoApagado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFocoApagado.TabIndex = 27;
            this.imgFocoApagado.TabStop = false;
            // 
            // imgFocoEncendido
            // 
            this.imgFocoEncendido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgFocoEncendido.BackgroundImage = global::_3OLIDST_JulianCastro_07.Properties.Resources.FocoEncendido;
            this.imgFocoEncendido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgFocoEncendido.Location = new System.Drawing.Point(333, 136);
            this.imgFocoEncendido.Name = "imgFocoEncendido";
            this.imgFocoEncendido.Size = new System.Drawing.Size(107, 117);
            this.imgFocoEncendido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFocoEncendido.TabIndex = 26;
            this.imgFocoEncendido.TabStop = false;
            this.imgFocoEncendido.Visible = false;
            // 
            // btnApagado
            // 
            this.btnApagado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApagado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.btnApagado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApagado.BackgroundImage")));
            this.btnApagado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApagado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.btnApagado.Location = new System.Drawing.Point(322, 271);
            this.btnApagado.Name = "btnApagado";
            this.btnApagado.Size = new System.Drawing.Size(135, 122);
            this.btnApagado.TabIndex = 1;
            this.btnApagado.UseVisualStyleBackColor = false;
            this.btnApagado.Click += new System.EventHandler(this.btnApagado_Click);
            // 
            // btnEncendido
            // 
            this.btnEncendido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEncendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.btnEncendido.BackgroundImage = global::_3OLIDST_JulianCastro_07.Properties.Resources.descarga_removebg_preview__1_;
            this.btnEncendido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEncendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncendido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.btnEncendido.Location = new System.Drawing.Point(322, 271);
            this.btnEncendido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncendido.Name = "btnEncendido";
            this.btnEncendido.Size = new System.Drawing.Size(135, 122);
            this.btnEncendido.TabIndex = 2;
            this.btnEncendido.UseVisualStyleBackColor = false;
            this.btnEncendido.Visible = false;
            this.btnEncendido.Click += new System.EventHandler(this.btnEncendido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgFocoApagado);
            this.Controls.Add(this.imgFocoEncendido);
            this.Controls.Add(this.btnApagado);
            this.Controls.Add(this.btnEncendido);
            this.Name = "Form1";
            this.Text = "Encendiendo LED con Arduino";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.imgFocoApagado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFocoEncendido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApagado;
        private System.Windows.Forms.Button btnEncendido;
        private System.Windows.Forms.PictureBox imgFocoApagado;
        private System.Windows.Forms.PictureBox imgFocoEncendido;
    }
}


namespace Philosophers
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
            this.startButton = new System.Windows.Forms.Button();
            this.BW_UpdateForm = new System.ComponentModel.BackgroundWorker();
            this.LBL_Philosopher0 = new System.Windows.Forms.Label();
            this.LBL_Philosopher4 = new System.Windows.Forms.Label();
            this.LBL_Philosopher3 = new System.Windows.Forms.Label();
            this.LBL_Philosopher2 = new System.Windows.Forms.Label();
            this.LBL_Philosopher1 = new System.Windows.Forms.Label();
            this.LB_Info = new System.Windows.Forms.ListBox();
            this.PB_Fork0 = new System.Windows.Forms.PictureBox();
            this.PB_Fork1 = new System.Windows.Forms.PictureBox();
            this.PB_Fork4 = new System.Windows.Forms.PictureBox();
            this.PB_Fork2 = new System.Windows.Forms.PictureBox();
            this.PB_Fork3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fork0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fork4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fork2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fork3)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(616, 55);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(112, 36);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Comenzar";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // BW_UpdateForm
            // 
            this.BW_UpdateForm.WorkerReportsProgress = true;
            this.BW_UpdateForm.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_UpdateForm_DoWork);
            this.BW_UpdateForm.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BW_UpdateForm_ProgressChanged);
            // 
            // LBL_Philosopher0
            // 
            this.LBL_Philosopher0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Philosopher0.Location = new System.Drawing.Point(490, 496);
            this.LBL_Philosopher0.Name = "LBL_Philosopher0";
            this.LBL_Philosopher0.Size = new System.Drawing.Size(82, 93);
            this.LBL_Philosopher0.TabIndex = 7;
            this.LBL_Philosopher0.Text = "Filósofo 1";
            this.LBL_Philosopher0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Philosopher4
            // 
            this.LBL_Philosopher4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_Philosopher4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Philosopher4.Location = new System.Drawing.Point(350, 295);
            this.LBL_Philosopher4.Name = "LBL_Philosopher4";
            this.LBL_Philosopher4.Size = new System.Drawing.Size(82, 97);
            this.LBL_Philosopher4.TabIndex = 14;
            this.LBL_Philosopher4.Text = "Filósofo 5";
            this.LBL_Philosopher4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Philosopher3
            // 
            this.LBL_Philosopher3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Philosopher3.Location = new System.Drawing.Point(612, 94);
            this.LBL_Philosopher3.Name = "LBL_Philosopher3";
            this.LBL_Philosopher3.Size = new System.Drawing.Size(82, 84);
            this.LBL_Philosopher3.TabIndex = 13;
            this.LBL_Philosopher3.Text = "Filósofo 4";
            this.LBL_Philosopher3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Philosopher2
            // 
            this.LBL_Philosopher2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Philosopher2.Location = new System.Drawing.Point(957, 286);
            this.LBL_Philosopher2.Name = "LBL_Philosopher2";
            this.LBL_Philosopher2.Size = new System.Drawing.Size(82, 97);
            this.LBL_Philosopher2.TabIndex = 12;
            this.LBL_Philosopher2.Text = "Filósofo 3";
            this.LBL_Philosopher2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Philosopher1
            // 
            this.LBL_Philosopher1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Philosopher1.Location = new System.Drawing.Point(781, 496);
            this.LBL_Philosopher1.Name = "LBL_Philosopher1";
            this.LBL_Philosopher1.Size = new System.Drawing.Size(82, 93);
            this.LBL_Philosopher1.TabIndex = 11;
            this.LBL_Philosopher1.Text = "Filósofo 2";
            this.LBL_Philosopher1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Info
            // 
            this.LB_Info.BackColor = System.Drawing.SystemColors.Control;
            this.LB_Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LB_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Info.ItemHeight = 17;
            this.LB_Info.Items.AddRange(new object[] {
            " ",
            " ",
            " ",
            " ",
            " "});
            this.LB_Info.Location = new System.Drawing.Point(50, 94);
            this.LB_Info.Name = "LB_Info";
            this.LB_Info.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LB_Info.Size = new System.Drawing.Size(203, 289);
            this.LB_Info.Sorted = true;
            this.LB_Info.TabIndex = 15;
            // 
            // PB_Fork0
            // 
            this.PB_Fork0.Image = global::Philosophers.Properties.Resources.Fork0;
            this.PB_Fork0.Location = new System.Drawing.Point(616, 427);
            this.PB_Fork0.Name = "PB_Fork0";
            this.PB_Fork0.Size = new System.Drawing.Size(130, 152);
            this.PB_Fork0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Fork0.TabIndex = 5;
            this.PB_Fork0.TabStop = false;
            // 
            // PB_Fork1
            // 
            this.PB_Fork1.Image = global::Philosophers.Properties.Resources.Fork1;
            this.PB_Fork1.Location = new System.Drawing.Point(835, 370);
            this.PB_Fork1.Name = "PB_Fork1";
            this.PB_Fork1.Size = new System.Drawing.Size(116, 116);
            this.PB_Fork1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Fork1.TabIndex = 4;
            this.PB_Fork1.TabStop = false;
            // 
            // PB_Fork4
            // 
            this.PB_Fork4.Image = global::Philosophers.Properties.Resources.Fork4;
            this.PB_Fork4.Location = new System.Drawing.Point(429, 370);
            this.PB_Fork4.Name = "PB_Fork4";
            this.PB_Fork4.Size = new System.Drawing.Size(124, 123);
            this.PB_Fork4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Fork4.TabIndex = 3;
            this.PB_Fork4.TabStop = false;
            // 
            // PB_Fork2
            // 
            this.PB_Fork2.Image = global::Philosophers.Properties.Resources.Fork2;
            this.PB_Fork2.Location = new System.Drawing.Point(758, 155);
            this.PB_Fork2.Name = "PB_Fork2";
            this.PB_Fork2.Size = new System.Drawing.Size(105, 98);
            this.PB_Fork2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Fork2.TabIndex = 2;
            this.PB_Fork2.TabStop = false;
            // 
            // PB_Fork3
            // 
            this.PB_Fork3.Image = global::Philosophers.Properties.Resources.Fork3;
            this.PB_Fork3.Location = new System.Drawing.Point(458, 156);
            this.PB_Fork3.Name = "PB_Fork3";
            this.PB_Fork3.Size = new System.Drawing.Size(114, 114);
            this.PB_Fork3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Fork3.TabIndex = 1;
            this.PB_Fork3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 627);
            this.Controls.Add(this.LB_Info);
            this.Controls.Add(this.LBL_Philosopher4);
            this.Controls.Add(this.LBL_Philosopher3);
            this.Controls.Add(this.LBL_Philosopher2);
            this.Controls.Add(this.LBL_Philosopher1);
            this.Controls.Add(this.LBL_Philosopher0);
            this.Controls.Add(this.PB_Fork0);
            this.Controls.Add(this.PB_Fork1);
            this.Controls.Add(this.PB_Fork4);
            this.Controls.Add(this.PB_Fork2);
            this.Controls.Add(this.PB_Fork3);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fork0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fork4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fork2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fork3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.ComponentModel.BackgroundWorker BW_UpdateForm;
        private System.Windows.Forms.PictureBox PB_Fork3;
        private System.Windows.Forms.PictureBox PB_Fork2;
        private System.Windows.Forms.PictureBox PB_Fork4;
        private System.Windows.Forms.PictureBox PB_Fork1;
        private System.Windows.Forms.PictureBox PB_Fork0;
        private System.Windows.Forms.Label LBL_Philosopher0;
        private System.Windows.Forms.Label LBL_Philosopher4;
        private System.Windows.Forms.Label LBL_Philosopher3;
        private System.Windows.Forms.Label LBL_Philosopher2;
        private System.Windows.Forms.Label LBL_Philosopher1;
        private System.Windows.Forms.ListBox LB_Info;
    }
}


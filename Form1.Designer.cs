namespace MovieSelector
{
    partial class movieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movieForm));
            this.listBoxMovies = new System.Windows.Forms.ListBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblAll = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxMovies
            // 
            this.listBoxMovies.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMovies.FormattingEnabled = true;
            this.listBoxMovies.ItemHeight = 15;
            this.listBoxMovies.Items.AddRange(new object[] {
            "Dumb and Dumber To",
            "Big Hero 6",
            "Interstellar",
            "Gone Girl"});
            this.listBoxMovies.Location = new System.Drawing.Point(12, 46);
            this.listBoxMovies.Name = "listBoxMovies";
            this.listBoxMovies.Size = new System.Drawing.Size(259, 64);
            this.listBoxMovies.TabIndex = 0;
            this.listBoxMovies.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBoxMovies.MouseLeave += new System.EventHandler(this.listBox1_MouseLeave);
            this.listBoxMovies.MouseHover += new System.EventHandler(this.listBox1_MouseHover);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(23, 21);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(241, 15);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Select a movie title to see starting times:";
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.lblAll.Location = new System.Drawing.Point(12, 113);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(259, 60);
            this.lblAll.TabIndex = 2;
            this.lblAll.Text = resources.GetString("lblAll.Text");
            this.lblAll.Visible = false;
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(12, 125);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(35, 13);
            this.lblMovie.TabIndex = 3;
            this.lblMovie.Text = "movie";
            this.lblMovie.Visible = false;
            this.lblMovie.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblMovie_MouseClick);
            // 
            // movieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 182);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.listBoxMovies);
            this.Name = "movieForm";
            this.Text = "Movie Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMovies;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.Label lblMovie;
    }
}


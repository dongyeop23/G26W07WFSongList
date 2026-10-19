namespace G26W07WFSongList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listSong = new ListBox();
            txtTitle = new TextBox();
            txtArtist = new TextBox();
            txtRating = new TextBox();
            btnAdd = new Button();
            txtSelected = new TextBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // listSong
            // 
            listSong.FormattingEnabled = true;
            listSong.Location = new Point(8, 8);
            listSong.Name = "listSong";
            listSong.Size = new Size(385, 364);
            listSong.TabIndex = 0;
            listSong.SelectedIndexChanged += OnChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(9, 380);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "제목";
            txtTitle.Size = new Size(144, 23);
            txtTitle.TabIndex = 1;
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(159, 380);
            txtArtist.Name = "txtArtist";
            txtArtist.PlaceholderText = "가수";
            txtArtist.Size = new Size(104, 23);
            txtArtist.TabIndex = 2;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(269, 380);
            txtRating.MaxLength = 1;
            txtRating.Name = "txtRating";
            txtRating.PlaceholderText = "평점";
            txtRating.Size = new Size(53, 23);
            txtRating.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(328, 380);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 25);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OnAdd;
            // 
            // txtSelected
            // 
            txtSelected.Enabled = false;
            txtSelected.Location = new Point(9, 415);
            txtSelected.Name = "txtSelected";
            txtSelected.PlaceholderText = "삭제를 위한 선택된 노래";
            txtSelected.ReadOnly = true;
            txtSelected.Size = new Size(313, 23);
            txtSelected.TabIndex = 5;
            txtSelected.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(328, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += OnDelete;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 450);
            Controls.Add(btnDelete);
            Controls.Add(txtSelected);
            Controls.Add(btnAdd);
            Controls.Add(txtRating);
            Controls.Add(txtArtist);
            Controls.Add(txtTitle);
            Controls.Add(listSong);
            Name = "Form1";
            Text = "애창곡";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listSong;
        private TextBox txtTitle;
        private TextBox txtArtist;
        private TextBox txtRating;
        private Button btnAdd;
        private TextBox txtSelected;
        private Button btnDelete;
    }
}

using System.Drawing;
using System.Windows.Forms;

namespace EBook
{
    partial class FormRead
    {
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxListChapter;
        private System.Windows.Forms.RichTextBox Content;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLinkLabel;

        private string title;
        private string novel;
        private int Number_Chapter;
        Image coverImage;

        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        


        private void InitializeComponent()
        {

            coverImage = res.GetProperty(novel + "_cover").GetValue(r) as Image;
            Number_Chapter = int.Parse(res.GetProperty(novel + "_info").GetValue(r) as string);

            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxListChapter = new System.Windows.Forms.PictureBox();
            this.Content = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanelLinkLabel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxListChapter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = global::EBook.Properties.Resources.smallBCC_CLASS_HOME_05;
            this.pictureBoxHome.Location = new System.Drawing.Point(5, 3);
            this.pictureBoxHome.Size = new System.Drawing.Size(76, 81);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHome.TabIndex = 0;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Image = global::EBook.Properties.Resources.listTruyen2;
            this.pictureBoxSearch.Location = new System.Drawing.Point(616, 6);
            this.pictureBoxSearch.Size = new System.Drawing.Size(384, 37);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearch.TabIndex = 1;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.White;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSearch.Image = global::EBook.Properties.Resources.kripto_search_b;
            this.buttonSearch.Location = new System.Drawing.Point(1006, 6);
            this.buttonSearch.Size = new System.Drawing.Size(60, 37);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(630, 14);
            this.textBoxSearch.Size = new System.Drawing.Size(354, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBoxListChapter
            // 
            this.pictureBoxListChapter.Image = global::EBook.Properties.Resources.listTruyen2Xoay;
            this.pictureBoxListChapter.Location = new System.Drawing.Point(-3, 90);
            this.pictureBoxListChapter.Size = new System.Drawing.Size(93, 466);
            this.pictureBoxListChapter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxListChapter.TabIndex = 4;
            this.pictureBoxListChapter.TabStop = false;
            this.pictureBoxListChapter.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(106, 67);
            this.Content.Size = new System.Drawing.Size(960, 474);
            this.Content.TabIndex = 6;
            this.Content.Text = "";
            // 
            // flowLayoutPanelLinkLabel
            // 
            this.flowLayoutPanelLinkLabel.AutoScroll = true;
            this.flowLayoutPanelLinkLabel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelLinkLabel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelLinkLabel.Location = new System.Drawing.Point(13, 102);
            this.flowLayoutPanelLinkLabel.Size = new System.Drawing.Size(64, 439);
            this.flowLayoutPanelLinkLabel.TabIndex = 7;
            this.flowLayoutPanelLinkLabel.WrapContents = false;
            this.flowLayoutPanelLinkLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);

            //link label
            for (int i = 0; i < Number_Chapter; i++)
            {
                LinkLabel chapterLink = new LinkLabel();
                chapterLink.AutoSize = true;
                chapterLink.TabIndex = 4;
                chapterLink.TabStop = true;
                chapterLink.Text = "Hồi " + (i + 1);
                chapterLink.Name = (i + 1).ToString();
                chapterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.chapterLink_LinkClicked);

                flowLayoutPanelLinkLabel.Controls.Add(chapterLink);
            }
            // 
            // FormRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.flowLayoutPanelLinkLabel);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.pictureBoxListChapter);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.pictureBoxHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = title;
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = title;//
            this.Load += new System.EventHandler(this.FormRead_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxListChapter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            SetCover();

        }

        private void SetCover()

        {
            Clipboard.SetImage(coverImage);
            this.Content.Paste();
            this.Content.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
        }


    }
}
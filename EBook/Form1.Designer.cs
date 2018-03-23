using EBook.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EBook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.RichTextBox Content;
        private Button titleButton;
        private string title;
        private string novel;
        private int Number_Chapter;
        Image coverImage;
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
        private void InitializeComponent(string novel, string title)
        {
            this.novel = novel;
            this.title = title;
            this.nextButton = new System.Windows.Forms.Button();
            this.Content = new System.Windows.Forms.RichTextBox();
            this.titleButton = new System.Windows.Forms.Button();
            
            coverImage = res.GetProperty(novel + "_cover").GetValue(r) as Image;
            Number_Chapter = int.Parse(res.GetProperty(novel + "_info").GetValue(r) as string);

            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(1051, 112);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // Content
            // 
            this.Content.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Content.Location = new System.Drawing.Point(290, 167);
            this.Content.Name = "Content";
            this.Content.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Content.Size = new System.Drawing.Size(827, 469);
            this.Content.TabIndex = 2;
            this.Content.Text = "   ";
            // 
            // titleButton
            // 
            this.titleButton.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.titleButton.Location = new System.Drawing.Point(485, 48);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(471, 87);
            this.titleButton.TabIndex = 3;
            this.titleButton.Text = title;
            this.titleButton.UseVisualStyleBackColor = true;
            this.titleButton.Click += new System.EventHandler(this.titleButton_Click);
            // 
            // chapterLink
            // 
            int x = 12;
            const int y = 162;
            const int width = 60;
            const int height = 50;
            int step = 0;
            //link label
            for (int i = 0; i < 37; i++)
            {
                LinkLabel chapterLink = new LinkLabel();
                chapterLink.AutoSize = true;
                chapterLink.TabIndex = 4;
                chapterLink.TabStop = true;
                chapterLink.Text = "Hồi " + (i + 1);
                chapterLink.Name = (i + 1).ToString();
                //chapterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.chapterLink_LinkClicked);

                //flowLayoutPanelLinkLabel.Controls.Add(chapterLink);
            }
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 661);
            
            this.Controls.Add(this.titleButton);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.nextButton);
            this.Name = "Form1";
            this.Text = "Ebook";
            this.Load += new System.EventHandler(this.Form1_Load);
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

        #endregion
       
    }
}


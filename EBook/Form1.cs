using System;

using System.Windows.Forms;
using EBook.Properties;
using CheckRule;
using System.Drawing;

namespace EBook
{


    public partial class Form1 : Form
    {
       
        private int number = 1;
        Type res = typeof(Resources);
        Resources r = new Resources();

        public Form1(string novel, string title)
        {
            InitializeComponent(novel, title);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Content.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            String Chapter = novel + "_c" + number;
            

            String ChapterContent = res.GetProperty(Chapter).GetValue(r) as String;
            this.Content.Text = ChapterContent;
            markText(ChapterContent);
            if (number < Number_Chapter)
                number++;
            else
                number = 1;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void titleButton_Click(object sender, EventArgs e)
        {
            this.Content.Text = " ";
            number = 1;
            this.SetCover();
            
        }

        private void chapterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel LinkChapter = sender as LinkLabel;
            number = int.Parse(LinkChapter.Name);
            this.Content.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            string Chapter = novel + "_c" + number;
            string ChapterContent = res.GetProperty(Chapter).GetValue(r) as String;
            
            this.Content.Text = ChapterContent;
            markText(ChapterContent);


            if (number < Number_Chapter)
                number++;
            else
                number = 1;
        }
        private void markText(string ChapterContent)
        {
            string[] wrongWords = CheckVietnamese.Check(ChapterContent);
            int len = Content.TextLength;
            foreach (string wrongWord in wrongWords)
            {
                int index = 0;

                int lastIndex = Content.Text.LastIndexOf(wrongWord);
                while (index < lastIndex)
                {

                    int indexTemp = Content.Find(wrongWord, index, len, RichTextBoxFinds.None);

                    Content.SelectionBackColor = Color.Red;

                    index = indexTemp + 1;

                }
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }


}

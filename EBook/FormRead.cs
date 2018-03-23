using CheckRule;
using EBook.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SearchKey;
using System.Text.RegularExpressions;

namespace EBook
{
    public partial class FormRead : Form
    {
        private int number = 1;
        Type res = typeof(Resources);
        Resources r = new Resources();
        public FormRead(string title, string novel)
        {
            this.novel = novel;
            this.title = title;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormRead_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            /*
            int index = 0; string temp = Content.Text; Content.Text = ""; Content.Text = temp;
            while (index < Content.Text.LastIndexOf(textBoxSearch.Text))
            {
                Content.Find(textBoxSearch.Text, index, Content.TextLength, RichTextBoxFinds.None);
                Content.SelectionBackColor = Color.Yellow;
                index = Content.Text.IndexOf(textBoxSearch.Text, index) + 1;
            }
            */

            // @"[^.-:;!\n?]*Người.*?màu[^.:;!\n?]*[.:;!\n?]"
            Content.SelectAll();
            Content.SelectionColor = Color.Black;
            Content.SelectionBackColor = Color.White;
            string[] key = textBoxSearch.Text.Split(' ');
            string pattern= "[^.-:;!\\n?]*";
            for(int i=0;i<key.Length;i++){
                pattern += key[i];
                if (i != key.Length - 1)
                    pattern += ".*?";
            }
            pattern += "[^.:;!\\n?]*[.:;!\\n?]";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(Content.Text);

            //Trường hợp tìm thấy xâu theo thứ tự
            if (matches.Count > 0) 
            {
                this.Content.Select(matches[0].Index, 0);
                this.Content.Focus();
                foreach (Match m in matches)
                {
                    Content.Select(m.Index, m.Length);
                    Content.SelectionColor = Color.Yellow;
                    Content.SelectionBackColor = Color.Black;
                }
            }
            else
            {
                //Trường hợp không tìm thấy xâu theo thứ tự, Hàm của Hùng, nếu k có thì hiển thị form k tìm thấy

            }

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
            textBoxSearch.Focus();
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
    }
}

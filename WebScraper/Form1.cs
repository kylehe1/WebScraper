using System.Collections.Generic;
using CsvHelper;
using HtmlAgilityPack;
using System.IO;
using System.Globalization;

namespace WebScraper
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            HtmlWeb web = new HtmlWeb();

            HtmlAgilityPack.HtmlDocument doc = web.Load("https://en.wikipedia.org/wiki/Greece");

            var HeaderNames =
                doc.DocumentNode.SelectNodes("//span[@class='toctext']");
        }
    }
}
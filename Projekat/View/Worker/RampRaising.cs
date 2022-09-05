using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS.View
{
    public partial class RampRaising : Form
    {
        public RampRaising()
        {
            InitializeComponent();
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='600' height='300' frameborder='0' allowfullscreen  /iframe>";
            html += "</head></html>";
            webBrowser1.DocumentText = string.Format(html, "Hwkm-lUkq9k");
            // doraditi da se video pusta sam i nakon sto se yavrsi da se proyor yatvori
            
        }
    }
}

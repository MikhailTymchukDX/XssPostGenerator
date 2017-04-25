using System;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Windows.Forms;

namespace XssPostGenerator {
    public partial class Form1 : Form {
        string markupTemplate = @"<!DOCTYPE html>
<html>
<head>
    <title></title>
	<meta charset=""utf-8"" />
</head>
<body>
    <form name = ""test"" method=""post"" action=""PAGE_ADDRESS_HERE"">
{0}</form>
        <script>        
            test.submit();
        </script>
    </body>
</html>";

        public Form1() {
            InitializeComponent();
        }

        string WriteParamMarkup(string paramsMarkup, string key, string value) {
            return String.Format("<input type=\"text\" hidden=\"hidden\" name=\"{0}\" value=\"{1}\" />", key, value) + Environment.NewLine;
        }

        private void txtRawData_TextChanged(object sender, EventArgs e) {
            try {
                var text = txtRawData.Text;
                var paramsKeyValue = text.Split('&');
                var paramsMarkup = "";

                foreach(var keyValue in paramsKeyValue) {
                    var keyValueSplitted = keyValue.Split('=');
                    var key = HttpUtility.UrlDecode(keyValueSplitted[0]);
                    var value = HttpUtility.UrlDecode(keyValueSplitted[1]);
                    paramsMarkup += WriteParamMarkup(paramsMarkup, key, value);

                    WriteViewstate(key, value);
                    WriteEventValidation(key, value);
                }

                txtMarkup.Text = String.Format(markupTemplate, paramsMarkup);
            } catch {
                txtMarkup.Text = "ERROR";
            }
        }

        private void WriteEventValidation(string key, string value) {
            if(key == "__EVENTVALIDATION") {
                var formatter = new ObjectStateFormatter();
                var array = formatter.Deserialize(value);
            }
        }

        private void WriteViewstate(string key, string value) {
            if(key == "__VIEWSTATE") {
                byte[] data = Convert.FromBase64String(value);
                string decodedString = Encoding.UTF8.GetString(data);
                txtViewState.Text = decodedString;
            }
        }
    }
}

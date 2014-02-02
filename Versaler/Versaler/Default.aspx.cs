using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Versaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CountCapitalsButton_Click(object sender, EventArgs e)
        {
            var text = Textarea.Text;
            var numberOfCapitals = Model.TextAnalyzer.GetNumberOfCapitals(text);

            ResultLabel.Text = string.Format("Det finns totalt {0} versaler!", numberOfCapitals);
            Textarea.Enabled = false;
            CountCapitalsButton.Enabled = false;
            CountCapitalsButton.Visible = false;
            CleanUpButton.Visible = true;
            CleanUpButton.Enabled = true;
        }

        protected void CleanUpButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);

            // Man hade kunnat göra såhär också, men det känns inte som ett bra sätt när man har större sidor.
            //textarea.Enabled = true;
            //textarea.Text = string.Empty;
            //countCapitalsButton.Enabled = true;
            //countCapitalsButton.Visible = true;
            //cleanUpButton.Visible = false;
            //cleanUpButton.Visible = false;
            //resultLabel.Text = string.Empty;
        }
    }
}
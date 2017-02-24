using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitRegistration()
    {
        string lastname = LastNameTextBox.Text;
        string firstname = FirstNameTextBox.Text;
        string email = EmailTextBox.Text;
        string apartment = ApartmentTextBox.Text;
        string street = StreetTextBox.Text;
        string city = CityTextBox.Text;
        string state = StateTextBox.Text;
        string zip = ZipcodeTextBox.Text;
        string homephone = HomePhoneTextBox.Text;
        string workphone = WorkPhoneTextBox.Text;
        string password = PasswordTextBox.Text;

        Community_AssistEntities commAssEnt = new Community_AssistEntities();
        int result = commAssEnt.usp_Register(lastname, firstname, email, password, apartment, street, city, state, zip, homephone, workphone); 

        if(result != -1)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ResultLabel.Text = "Error in Registration";
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        SubmitRegistration();
    }
}
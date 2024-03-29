﻿
<%@ Page Language="C#" AutoEventWireup="True" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>CheckBox CheckedChanged Example</title>
<script runat="server">

    void Check_Clicked(Object sender, EventArgs e)
    {

        // Calculate the subtotal and display the result in currency format.
        // Include tax if the check box is selected.
        if(checkbox1.Checked)
        {
            divSolicitaLicenca.Visible = true;
        }

    }

    void Page_Load(Object sender, EventArgs e)
    {

        // Display the subtotal without tax when the page is first loaded.
        //if(!IsPostBack)
        //{

        //    // Calculate the subtotal and display the result in currency format.
        //    Message.Text = CalculateTotal(false).ToString("c");

        //}

        divSolicitaLicenca.Visible = false;

    }

    double CalculateTotal(bool Taxable)
    {

        // Calculate the subtotal for the example.
        double Result = 1.99 + 2.99 + 3.99;

        // Add tax, if applicable.
        if(Taxable)
        {
            Result += Result * 0.086;
        }

        return Result;

    }

   </script>
 
</head>
 
<body>
 
   <form id="form1" runat="server">
 
      <h3>CheckBox CheckedChanged Example</h3>

      Select whether to include tax in the subtotal.

      <br /><br />

      <table border="1" cellpadding="5">

         <tr>

            <th colspan="2">

               Shopping cart

            </th>

         </tr>

         <tr>

            <td>

               Item 1

            </td>

            <td>

               $1.99

            </td>

         </tr>

         <tr>

            <td>

               Item 2

            </td>

            <td>

               $2.99

            </td>

         </tr>

         <tr>

            <td>

               Item 3

            </td>

            <td>

               $3.99

            </td>

         </tr>

         <tr>

            <td>

               <b>Subtotal</b>

            </td>

            <td>

               <asp:Label id="Message" runat="server"/>

            </td>

         </tr>

         <tr>

            <td colspan="2">

               <asp:CheckBox id="checkbox1" runat="server"
                    AutoPostBack="True"
                    Text="Include 8.6% sales tax"
                    TextAlign="Right"
                    OnCheckedChanged="Check_Clicked"/>

            </td>

         </tr>

      </table>

        <div runat="server" id="divSolicitaLicenca">
            <asp:Button ID="btnSolicita_Licenca" runat="server" Text="Solicitar Licença" CssClass="btn btn-danger"/>
        </div>
                   
   </form>
         
</body>

</html>
<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="CalculatorProjectH.Calculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4 mt-5 ms-5">
                    
            <table CssClass="">
             <tr>
                 <td colspan="4">
                     <asp:TextBox ID="TextBox1" CssClass="form-control input-element" runat="server"></asp:TextBox>
                 </td>
             </tr>
            <tr>
                <td>
                    <asp:Button Text="7" CssClass="btn btn-primary" runat="server" /></td>
                <td>
                    <asp:Button Text="8" CssClass="btn btn-primary" runat="server" /></td>
                <td>
                    <asp:Button Text="9" CssClass="btn btn-primary" runat="server" /></td>
                <td>
                    <asp:Button Text="%" CssClass="btn btn-danger" runat="server" /></td>
            </tr>
              <tr>
                <td>
                    <asp:Button Text="4" CssClass="btn btn-primary" runat="server" /></td>
                <td>
                    <asp:Button Text="5" CssClass="btn btn-primary" runat="server" /></td>
                <td>
                    <asp:Button Text="6" CssClass="btn btn-primary" runat="server" /></td>
                <td>
                    <asp:Button Text="-" CssClass="btn btn-danger" runat="server" /></td>
            </tr>
              <tr>
                <td>
                    <asp:Button Text="1" CssClass="btn btn-primary" runat="server" /></td>
                <td>
                    <asp:Button Text="2" CssClass="btn btn-primary" runat="server" /></td>
                <td>
                    <asp:Button Text="3" CssClass="btn btn-primary" runat="server" /></td>
                <td>
                    <asp:Button Text="+" CssClass="btn btn-danger" runat="server" /></td>
            </tr>
              <tr>
                <td>
                    <asp:Button Text="*" CssClass="btn btn-danger" runat="server" /></td>
                <td>
                    <asp:Button Text="/" CssClass="btn btn-danger" runat="server" /></td>
                <td>
                    <asp:Button Text="C" CssClass="btn btn-danger" runat="server" /></td>
                <td>
                    <asp:Button Text="Back" CssClass="btn btn-danger" runat="server" /></td>
            </tr>
        </table>
        </div>
               
                <div class="col-md-4"></div>
            </div>
        </div>

</asp:Content>

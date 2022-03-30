<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="APP_Test.MyPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Advanced ASP.NET Web Server Controls</h2>
    <h3>Create a list of events in a repeater from a calendar control</h3>
    <div class="form-group">
        <label>Event Name:</label>
        <asp:TextBox ID="txtEvent" CssClass="form-control" runat="server" />
    </div>
    <div class="form-group">
        <label>Event date:</label>
        <asp:Calendar ID="calendarEvents" runat="server" />
    </div>
    <div class="form-group">
        <asp:Button ID="btnEvent" runat="server" CssClass="btn btn-primary btn-large" Text="Add Event" OnClick="btnEvent_Click" />
    </div>
    <h3>Events Repeater</h3>
    <div>
        <asp:Repeater ID="rptEvents" runat="server" >
            <ItemTemplate>
                <h3><%# DataBinder.Eval(Container.DataItem, "EventDate") %>&nbsp;<small><%# DataBinder.Eval(Container.DataItem, "EventName") %></small></h3>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>

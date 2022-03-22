<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Test1.aspx.cs" Inherits="NandniWeb.Test1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Convert a Decimal Number to a Binary number "D2B"</h1>
    <hr />

    <div class="row">
        <div class="col-sm-6">
            <div class="card">
                <div class="card-header">
                    <h2>Enter the Decimal Number value to Convert "D2B"</h2> 
                </div>
                <div class="card-body">
                    <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" runat="server" class="btn btn-primary btn-block" Text="Convert" OnClick="Button1_Click" />

                    <h4 id="err" class="text-danger" runat="server"></h4>
                </div>
            </div>
        </div>
        <div class="col-sm-6">
             <div class="card">
                <div class="card-header">
                    <h2> Your Output here </h2>
                </div>
                <div class="card-body">
                    <h3 id="myValue" runat="server"></h3>
                    <h3 id="myResult" runat="server"></h3>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

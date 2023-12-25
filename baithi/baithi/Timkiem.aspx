<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Timkiem.aspx.cs" Inherits="baithi.Timkiem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        TÌM KIẾM THÔNG TIN TRƯỜNG 
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Nhập Mã trường:  "></asp:Label>
        <asp:TextBox ID="txtmatruong" runat="server"></asp:TextBox>
        <asp:Button ID="btnmatr" runat="server" Text="Tìm theo Mã" />
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Nhập Tên trường:  "></asp:Label>
        <asp:TextBox ID="txttentruong" runat="server"></asp:TextBox>
        <asp:Button ID="btntentr" runat="server" Text="Tìm theo Tên" />
    </div>
    <div>
        <asp:GridView ID="grvtruong" Width="600" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="MaTruong" HeaderText="Mã trường" />
                <asp:BoundField DataField="TenTruong" HeaderText="Tên trường" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
    <div style="border-top:1px dashed #000000;border-bottom:1px dashed #000000">
        <asp:Label ID="lblthongbao" runat="server" ForeColor="Red" Text="Label"></asp:Label>
    </div>
</asp:Content>

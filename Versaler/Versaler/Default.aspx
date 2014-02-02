<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Versaler.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="CapitalsLabel" runat="server" Text="Hur många versaler?"></asp:Label>
    </div>
        <p>
            <asp:TextBox ID="Textarea" runat="server" TextMode="MultiLine" Height="140px" Width="410px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="CleanUpButton" runat="server" Text="Rensa" Enabled="False" Visible="False" OnClick="CleanUpButton_Click" />
            <asp:Button ID="CountCapitalsButton" runat="server" Text="Bestäm antal versaler" OnClick="CountCapitalsButton_Click" />
            <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>

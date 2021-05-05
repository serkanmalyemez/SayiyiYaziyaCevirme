<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="YaziyaCevirme.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <div class="input-group mb-3">
                        <asp:TextBox ID="txbSayi" runat="server" class="form-control" placeholder="Recipient's username" aria-label="Recipient's username" aria-describedby="button-addon2" TextMode="Number"></asp:TextBox>
                        <asp:Button ID="btnIslem" runat="server" Text="Hesapla" class="btn btn-outline-secondary" OnClick="btnIslem_Click" />
                    </div>
                </div>
                <div class="col-sm-12">
                    <asp:Label ID="lblYazi" runat="server" Text="" class="form-label"></asp:Label>
                </div>
            </div>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>
</body>
</html>

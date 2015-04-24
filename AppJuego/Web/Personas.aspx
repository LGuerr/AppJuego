<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="AppJuego.Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Personas</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div  class = "page-header" > 
  <h1 style="width: 330px; margin-left: 337px"> Nueva Liga  <small> Juego </small> </h1> 
</div>
    <div  class = "jumbotron" > 
  <h1> Hola, Estas listo! </h1> 
  <p>Seguro </p> 
  <p> <a  class = "btn btn-primaria btn-lg"  href = "#"  role = "button" >En este juego podras crear tus propios Personajes, darles las caracteristicas que quieras. Que esperas comienza  </a> </p> 
</div>
        <div  class = "jumbotron" > 
  <div  class = "container" > 
    ...<asp:Button ID="Button1" runat="server" BackColor="Fuchsia" OnClick="Button1_Click" style="margin-left: 333px; margin-top: 0px" Text="Entrar" Width="269px" />
&nbsp;</div> </div>
    
    </div>
    </form>
</body>
</html>

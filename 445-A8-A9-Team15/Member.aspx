<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="_445_A8_A9_Team15.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1><asp:Label ID="Label1" runat="server" Text="Member Page"></asp:Label></h1>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Welcome back, " Font-Bold="True" Font-Size="Large"></asp:Label>
            <asp:Label ID="userName" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
            <p>
                <asp:Button ID="homePageButton" runat="server" Text="Home Page" OnClick="homePageButton_Click"/>
                <asp:Button ID="Logout" runat="server" Text="Log out" OnClick="Logout_Click" />
            </p>


            <%--Weather Service --%>
            <h3><asp:Label ID="Label3" runat="server" Text="5-Day Weather Forecast!"></asp:Label></h3>
            <p>  
                <asp:Label ID="Label4" runat="server" Text="Zip Code:        "></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="Grab Forecast" OnClick="Button2_Click" />
            </p>
            <p>
                <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label13" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label14" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label15" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label16" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label17" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label18" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label19" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label20" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label21" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label22" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label23" runat="server" Text=""></asp:Label>
            </p>


            <%-- MEASUREMENT CONVERSION STARTS HERE --%>
            <h3><asp:Label ID="Label24" runat="server" Text="Measurement Conversion!"></asp:Label></h3>
            <p>Enter a measurement to convert it from imperial units to metric units or vice versa.</p>
            <p>
                <asp:Label ID="metricTypeLabel" runat="server" Text="Choose metric unit type:"></asp:Label>
                <asp:DropDownList ID="MetricDropDown" runat="server">
                    <asp:ListItem Enabled="True" Text="mm"></asp:ListItem>
                    <asp:ListItem Enabled="True" Text="cm"></asp:ListItem>
                    <asp:ListItem Enabled="True" Text="m"></asp:ListItem>
                    <asp:ListItem Enabled="True" Text="km"></asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                <asp:Label ID="imperialTypeLabel" runat="server" Text="Choose imperial unit type:"></asp:Label>
                <asp:DropDownList ID="ImperialDropDown" runat="server">
                    <asp:ListItem Enabled="True" Text="in"></asp:ListItem>
                    <asp:ListItem Enabled="True" Text="ft"></asp:ListItem>
                    <asp:ListItem Enabled="True" Text="yd"></asp:ListItem>
                    <asp:ListItem Enabled="True" Text="mi"></asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                <asp:Label ID="textBoxInstructionLabel" runat="server" Text="Enter the value to be converted as a decimal in the text box below (e.g., if you
                    want to convert 32, enter it as 32.0)"></asp:Label>
            </p>
            <p>
                <asp:TextBox ID="TextBox2" placeholder="Decimal value" runat="server"></asp:TextBox>
                <asp:Label ID="ErrorMessage" runat="server"></asp:Label>
            </p>
            <asp:Button ID="Button1" runat="server" Text="Imperial to Metric" OnClick="Button1_Click" style="height: 26px"/> <asp:Button ID="Button3" runat="server" Text="Metric to Imperial" OnClick="Button3_Click" />
            <div>
            <%-- F) Results or output of service (label or listbox) --%>
                <p>
                <%--<asp:Label ID="Label1" runat="server" Text="Num2Words Service Results"></asp:Label>--%><br />
                <br />
                <br />
                <asp:Label ID="Label30" runat="server" Text="MeasurementConversion Results: "></asp:Label><br />
                <asp:Label ID="resultsLabel" runat="server"></asp:Label>
                </p>
            </div>


            <%-- Natural Hazard Service --%>
            <h3><asp:Label ID="Label25" runat="server" Text="Natural Hazard Rating Checker!"></asp:Label></h3>
            <div>
            <p>
                <%-- C) --%>
                <asp:Label ID="Label26" runat="server" Text="Returns a natural hazard safety rating based on a given zipcode. Please enter a zipcode below."></asp:Label>

                <br />
                <br />

                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                <br />

                <%-- E) --%>

                <asp:Button ID="Button5" runat="server" Text="Invoke Natural Hazard Service" Width="246px" OnClick="envokeNaturalHazardService_Click" />
                <br />
                <br />
                <asp:Label ID="Label31" runat="server" Text=" Natural Hazard Service Result"></asp:Label>
                <br />
                <asp:Label ID="Label32" runat="server" Text=" "></asp:Label>
                <br />

                <%-- F) --%>

                </p>

            </div>




            <%-- Zip To Location --%>
            <h3><asp:Label ID="Label29" runat="server" Text="Zipcode to Location Conversion!"></asp:Label></h3>
            <p>Enter a zipcode in order to convert it into a location.</p>
            <div>
            <p>
            <%-- D) Input TextBox --%>
            <%-- E) Buttons to call the services based on input from D --%>
                <asp:TextBox ID="TextBox3" runat="server">

                </asp:TextBox>
            </p>
            </div>
            <div>
            <%-- F) Results or output of service (label or listbox) --%>
            <p>
            <%--<asp:Label ID="Label1" runat="server" Text="Stemming Service Results"></asp:Label>--%>
                <asp:Button ID="Button4" runat="server" Text="Invoke ZipToLocation" OnClick="Button4_Click" Width="182px" />
            <br />
            <%--<asp:Label ID="Label6" runat="server" Text="Input Status: "></asp:Label><br />--%>
            <br />
            <asp:Label ID="Label27" runat="server" Text="Location Results: "></asp:Label><br />
            <asp:Label ID="Label28" runat="server" Text=" "></asp:Label>
            </p>
            </div>
         
        </div>
    </form>
</body>
</html>

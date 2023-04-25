<%@ Page Title="Try-It" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TryIt-Page.aspx.cs" Inherits="_445_A8_A9_Team15.TryIt_Page" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<%-- MEASUREMENT CONVERSION STARTS HERE --%>
    <div>
        <div class="">
            <h1><b>MeasurementConversion Service: Try-It Page</b></h1>
            <%-- A) sentence to describe the functions of each service --%>
            <h3>MeasurementConversion converts imperial units to metric units or vice versa.</h3>
            <%-- B) URL of the service (for A5 just have the localhost service) --%>
            <a href="http://webstrar164.fulton.asu.edu/page6/Service1.svc"><br />MEASUREMENTCONVERSION SERVICE LINK</a>
        </div>
        <div>
            <%-- C) Method names (param type list and return type --%>
            <br /><p> MeasurementConversion function: Input of two strings and a double with a return type of double</p>
        </div>
        <div>
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
                <asp:TextBox ID="TextBox1" placeholder="Decimal value" runat="server"></asp:TextBox>
                <asp:Label ID="ErrorMessage" runat="server"></asp:Label>
            </p>
            <asp:Button ID="Button1" runat="server" Text="Imperial to Metric" OnClick="Button1_Click"/> <asp:Button ID="Button2" runat="server" Text="Metric to Imperial" OnClick="Button2_Click"/>
        </div>
        <div>
            <%-- F) Results or output of service (label or listbox) --%>
            <p>
                <%--<asp:Label ID="Label1" runat="server" Text="Num2Words Service Results"></asp:Label>--%><br />
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="MeasurementConversion Results: "></asp:Label><br />
                <asp:Label ID="resultsLabel" runat="server"></asp:Label>
            </p>
        </div>
    </div>

<%-- MERGE SORT STARTS HERE --%>
    <div>
        <div class="">
            <h1><b>MergeSortNumberList Service: Try-It Page</b></h1>
            <%-- A) sentence to describe the functions of each service --%>
            <h3>MergeSortNumberList uses merge sort to sort a given string of numbers into ascending order.</h3>
            <%-- B) URL of the service (for A5 just have the localhost service) --%>
            <a href="http://webstrar164.fulton.asu.edu/page6/Service1.svc"><br />MERGESORTNUMBERLIST SERVICE LINK</a>
        </div>
        <div>
            <%-- C) Method names (param type list and return type --%>
            <br /><p> MergeSortNumberList function: Input of a string of numbers and return of a sorted string of numbers</p>
        </div>
        <div>
            <p>
                <%-- D) Input TextBox --%>
                <p>
                    <asp:Label runat="server" ID="InputLabel" Text="Please enter a series of numbers, in any order, separated by spaces (e.g., 3 9 1 12)"></asp:Label>
                </p>
                <p>
                    <asp:TextBox ID="InputTextBox" Placeholder="Type here..." runat="server" ></asp:TextBox>
                </p>
                <%-- E) Buttons to call the services based on input from D --%>
                <asp:Button ID="Button3" runat="server" Text="Invoke MergeSortNumberList" OnClick="Button3_Click"/>
            </p>
        </div>
        <div>
            <%-- F) Results or output of service (label or listbox) --%>
            <p>
                <%--<asp:Label ID="Label1" runat="server" Text="Num2Words Service Results"></asp:Label>--%><br />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="TimeZoneConversion Results: "></asp:Label><br />
                <asp:Label ID="Label2" runat="server" Text="Converted time zone appears here..."></asp:Label>
            </p>
        </div>
    </div>


    
<%-- GLOBAL.ASAX STARTS HERE --%>
    <div>
        <h1><b>Global.asax Event Handler</b></h1>
        <h3>The Global.asax Event Handler displays a welcome message when opening the application</h3>
        <p>There is no test case for this component but the user should have noticed the welcome message pop up on initial page load</p>
    </div>
</asp:Content>

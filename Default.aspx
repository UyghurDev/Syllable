<%@ Page Title="ئۇيغۇرچە بوغۇم ئايرىش (Split Syllables for Uyghur Language)" Language="C#" MasterPageFile="~/Common/Public.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Syllable_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td style="text-align: center">
                <br />
                ئۇيغۇرچە بوغۇم ئايرىش<br />
                Split Syllables for Uyghur Language<br />
                <hr class="HorzentalLineHeader" dir="rtl" />
            </td>
        </tr>
        <tr>
            <td>
                
                <table cellpadding="0" dir="rtl" 
                    style="border-collapse: collapse; width: 600px; border: 1px solid #d5ddf3" align="center">
                    <tr>
                        <td dir="ltr">
                            <asp:TextBox ID="txtSource" runat="server" Height="200px" TextMode="MultiLine" 
                                Width="600px" CssClass="TextBox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: center">
                            <asp:Button ID="btnGetSyllables" runat="server" onclick="btnTranclate_Click" 
                                Text="بوغۇم ئايرىش" />
                        </td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#CCCCFF">
                                                <asp:Literal ID="ltrlSyllables" runat="server"></asp:Literal>
                                            </td>
                                        </tr>
                                    </table>
                <br />
                بوغۇم ئايرىش پروگراممىسى: <a href="Uyghur_Syllable_Spliter_V0.1.rar">چۈشۈرۈش</a><br />
                Uyghur Syllable Spliter:<a href="Uyghur_Syllable_Spliter_V0.1.rar">Download</a>
                <br />
                <br />
                مۇناسىۋەتلىك ئۇلىنىشلار
                <hr align="right" class="HorzentalLineLinks" />
                
                <a href="http://www.uyghurdev.net/Web/Forum/FTopicView.aspx?TID=99">http://www.uyghurdev.net/Web/Forum/FTopicView.aspx?TID=99</a><br />
            </td>
        </tr>
    </table>

</asp:Content>


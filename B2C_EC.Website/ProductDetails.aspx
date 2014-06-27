﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="B2C_EC.Website.ProductDetails" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/style.css" rel="stylesheet" />
    <link href="Styles/component.css" rel="stylesheet" />    
    <script src="Scripts/jquery.cbpFWSlider.js"></script>
    <script src="Scripts/jquery.jqzoom-core.js"></script>
    <link href="Styles/jqzoom.css" rel="stylesheet" />
    <script>
        $(document).ready(function () {
            $('.jqzoom').jqzoom({
                zoomType: 'innerzoom',
                lens: true,
                preloadImages: false,
                alwaysOn: false
            });
        });
    </script>
    <style type="text/css">
        body {
            margin: 0px;
            padding: 0px;
            font-family: Arial;
        }

        a img, :link img, :visited img {
            border: none;
        }

        table {
            border-collapse: collapse;
            border-spacing: 0;
        }

        :focus {
            outline: none;
        }

        * {
            margin: 0;
            padding: 0;
        }

        p, blockquote, dd, dt {
            margin: 0 0 8px 0;
            line-height: 1.5em;
        }

        fieldset {
            padding: 0px;
            padding-left: 7px;
            padding-right: 7px;
            padding-bottom: 7px;
        }

            fieldset legend {
                margin-left: 15px;
                padding-left: 3px;
                padding-right: 3px;
                color: #333;
            }

        dl dd {
            margin: 0px;
        }

        dl dt {
        }

        .clearfix:after {
            clear: both;
            content: ".";
            display: block;
            font-size: 0;
            height: 0;
            line-height: 0;
            visibility: hidden;
        }

        .clearfix {
            display: block;
            zoom: 1;
        }


        ul#thumblist {
            display: block;
        }

            ul#thumblist li {
                float: left;
                margin-right: 2px;
                list-style: none;
            }

                ul#thumblist li a {
                    display: block;
                    border: 1px solid #CCC;
                }

                    ul#thumblist li a.zoomThumbActive {
                        border: 1px solid red;
                    }

        .jqzoom {
            text-decoration: none;
            float: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentMain" runat="server">
    <div style="height:400px;">
        <div class="Detail-Left">
            <div id="cbp-fwslider" class="cbp-fwslider">
                <div id="content" style="margin-top: 0px; margin-left: 0px; padding-bottom:0px; /*height: 398px;*/ width: 378px; margin:0 auto;" align="center">
                    <div style="width:100%; float:left;" align="center">
                        <asp:Repeater ID="rptImage" runat="server">
                            <ItemTemplate>
                                <a href='<%# SetImage(Eval("Image").ToString())%>' class="jqzoom" rel='gal1' title="triumph">
                                    <img src='<%# SetImage(Eval("Image").ToString())%>' height="390" width="370px" title="triumph" style="border: 4px solid #666;">
                                </a>
                            </ItemTemplate>
                        </asp:Repeater>
                        <%--<a href="imgProd/triumph_big1.jpg" class="jqzoom" rel='gal1' title="triumph">
                            <img src="imgProd/triumph_small1.jpg" title="triumph" style="border: 4px solid #666;">
                        </a>--%>
                    </div>
                    <div style="float:left; width:100%; height:100%;">
                        <asp:Repeater ID="rptListImages" runat="server">
                            <HeaderTemplate>
                                <ul id="thumblist" class="clearfix">
                            </HeaderTemplate>
                            <ItemTemplate>
                                <%--<li><a href='<%# SetImage(Eval("Image").ToString()) %>' rel="{gallery: 'gal1', smallimage: '<%# SetImage(Eval("Image").ToString()) %>',largeimage: '<%# SetImage(Eval("Image").ToString()) %>'}" class="jqzoom">
                                    <asp:Image ID="thumb" Height="300px" AlternateText='<%# Eval("Image") %>' runat="server" ImageUrl='<%# SetImage(Eval("Image")) %>' />
                                </a></li>--%>
                                <li>
                                    <a href='javascript:void(0);' rel="{gallery: 'gal1', smallimage: '<%# SetImage(Eval("Image").ToString())%>',largeimage: '<%# SetImage(Eval("Image").ToString())%>'}"><img src='<%# SetImage(Eval("Image").ToString())%>' width="50" /></a>
                                </li>
                            </ItemTemplate>
                            <FooterTemplate>
                                </ul>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
                </div>
                

				<%--<ul>
				    <li><a href="#"><img src="resources/images/1.jpg" alt="img01"/></a></li>

				    <li><a href="#"><img src="resources/images/2.jpg" alt="img02"/></a></li>
	
				    <li><a href="#"><img src="resources/images/3.jpg" alt="img03"/></a></li>
	
				    <li><a href="#"><img src="resources/images/4.jpg" alt="img04"/></a></li>			

				    <li><a href="#"><img src="resources/images/5.jpg" alt="img05"/></a></li>
				</ul>			--%>
            </div>
        </div>
        <div class="Detail-Right">
            <div class="cbp-fwslider2">
                <div class="titleh2">
                    Overview product
                </div>
                <table class="table-detail">
                    <tr>
                        <td style="width: 120px;"><b>Product Name:</b>
                        </td>
                        <td>
                            <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td><b>Price:</b>
                        </td>
                        <td>
                            <asp:Label ID="lblPrice" runat="server" Text="" ForeColor="#B12704"></asp:Label>
                        </td>
                    </tr>
                    <tr style="height: 50px;">
                        <td>
                            <b>Quantity:</b>
                        </td>
                        <td>
                            <asp:TextBox ID="txtQuantity" runat="server" Width="100px"></asp:TextBox>
                            <asp:NumericUpDownExtender ID="txtQuantity_NumericUpDownExtender" runat="server" Enabled="True" Maximum="10" Minimum="1" Step="1" TargetControlID="txtQuantity" Width="100">
                            </asp:NumericUpDownExtender>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <asp:Button ID="btnAddToCart" CssClass="ButtonOrange" runat="server" Text="Add to cart" OnClick="btnAddToCart_Click" />
                        </td>
                        <td>
                            <asp:Button ID="btnOrder" CssClass="ButtonOrange" runat="server" Text="Order" OnClick="btnOrder_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="TableDescription">
        <div class="titleh2">
            Product Details
        </div>
        <div class="Description">
            <asp:Literal ID="ltrDetails" runat="server"></asp:Literal>
        </div>
    </div>
</asp:Content>

<%@ Page language="c#" Codebehind="index.aspx.cs" AutoEventWireup="True" Inherits="医院管理系统.index" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>index</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	    <style type="text/css">
            .auto-style1 {
	height: 21px;
	text-align: center;
	font-size: xx-large;
	color: #FFF;
            }
            .auto-style2 {
	text-align: center;
	height: 28px;
	color: #F90;
            }
            #Form1 {
	color: #099;
}
        body {
	background-color: #099;
}
        </style>
    <meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table3" align="center" cellSpacing="1" cellPadding="1" width="300" border="1">
				<TR>
					<TD class="auto-style1"><strong>用户登录</strong></TD>
				</TR>
				<TR>
					<TD>
						<TABLE id="Table1" cellSpacing="0" cellPadding="0"  border="0" style="WIDTH: 608px; HEIGHT: 408px">
							<TR>
								<TD class="auto-style2">
									<MARQUEE onmouseover="this.stop()" style="WIDTH: 607px; HEIGHT: 26px" onmouseout="this.start()"
										scrollAmount="3" scrollDelay="70" direction="left"><FONT face="宋体" color="#FFFFFF" size="2">制作人：梁韬、朱宸。</FONT></MARQUEE>
								</TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 99px" align="center"><FONT face="宋体"></FONT></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 103px" align="center"><FONT face="宋体">
										<TABLE id="Table2" style="border-top-style: none; border-top-width: thin; WIDTH: 210px; HEIGHT: 90px"  cellSpacing="0"
											cellPadding="0" width="241" border="1">
											<TR>
												<TD width="237" style="HEIGHT: 21px"><FONT face="宋体"><FONT face="宋体">用户名:
															<asp:textbox id="Tname" runat="server" Width="137px" Font-Size="Medium"></asp:textbox></FONT></FONT></TD>
											</TR>
											<TR>
												<TD style="HEIGHT: 14px"><FONT face="宋体">密码:<asp:textbox id="Tpwd" runat="server" Width="136px" Font-Size="Medium" TextMode="Password" OnTextChanged="Tpwd_TextChanged"></asp:textbox>&nbsp;</FONT></TD>
											</TR>
											<TR>
												<TD align="center">
													<asp:button id="Button1" runat="server" Text="登入" onclick="Button1_Click"></asp:button>&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="注册" />
&nbsp;<asp:button id="Button2" runat="server" Text="返回主页" onclick="Button2_Click"></asp:button></TD>
											</TR>
										</TABLE>
										&nbsp;</FONT><FONT face="宋体, MS Song"> </FONT>
								</TD>
							</TR>
							<TR>
								<TD align="center"><FONT face="宋体"></FONT></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD></TD>
				</TR>
			</TABLE>
			&nbsp;
		</form>
	</body>
</HTML>

<%@ Page Language="C#" %>
<%@ Import namespace="System.Security.Principal" %>

<!DOCTYPE html>

<script runat="server">
    int x = 0;
    public bool WillFlowAcrossNetwork(WindowsIdentity w)
    {
        foreach (SecurityIdentifier s in w.Groups)
        {
            if (s.IsWellKnown(WellKnownSidType.InteractiveSid)) { x = 1; return true; }
            if (s.IsWellKnown(WellKnownSidType.BatchSid)) { x = 2; return true; }
            if (s.IsWellKnown(WellKnownSidType.ServiceSid)) { x = 3; return true; }
        }

        return false;
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
<%
  WindowsIdentity current =  WindowsIdentity.GetCurrent();
  Response.Write(current.Name + ", " + WillFlowAcrossNetwork(current) + ", " + x.ToString() + "<br />");
%>
</body>
</html>

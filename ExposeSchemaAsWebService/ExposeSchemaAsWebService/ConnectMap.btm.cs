namespace ExposeSchemaAsWebService {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ExposeSchemaAsWebService.InputSchema", typeof(global::ExposeSchemaAsWebService.InputSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ExposeSchemaAsWebService.OutputSchema", typeof(global::ExposeSchemaAsWebService.OutputSchema))]
    public sealed class ConnectMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://ExposeSchemaAsWebService.OutputSchema"" xmlns:s0=""http://ExposeSchemaAsWebService.InputSchema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Data"" />
  </xsl:template>
  <xsl:template match=""/s0:Data"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;Hello &quot; , string(Name/text()))"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:MathAdd(string(Value1/text()) , string(Value2/text()))"" />
    <ns0:Details>
      <Greetings>
        <xsl:value-of select=""$var:v1"" />
      </Greetings>
      <TotalValue>
        <xsl:value-of select=""$var:v2"" />
      </TotalValue>
    </ns0:Details>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}


public string MathAdd(string param0, string param1)
{
	System.Collections.ArrayList listValues = new System.Collections.ArrayList();
	listValues.Add(param0);
	listValues.Add(param1);
	double ret = 0;
	foreach (string obj in listValues)
	{
	double d = 0;
		if (IsNumeric(obj, ref d))
		{
			ret += d;
		}
		else
		{
			return """";
		}
	}
	return ret.ToString(System.Globalization.CultureInfo.InvariantCulture);
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"ExposeSchemaAsWebService.InputSchema";
        
        private const global::ExposeSchemaAsWebService.InputSchema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"ExposeSchemaAsWebService.OutputSchema";
        
        private const global::ExposeSchemaAsWebService.OutputSchema _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltEngine {
            get {
                return _xsltEngine;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"ExposeSchemaAsWebService.InputSchema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"ExposeSchemaAsWebService.OutputSchema";
                return _TrgSchemas;
            }
        }
    }
}

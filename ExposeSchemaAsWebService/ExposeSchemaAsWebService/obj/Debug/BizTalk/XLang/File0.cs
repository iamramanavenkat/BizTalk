
#pragma warning disable 162

namespace ExposeSchemaAsWebService
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Receive",
        new System.Type[]{
            typeof(ExposeSchemaAsWebService.__messagetype_ExposeSchemaAsWebService_InputSchema), 
            typeof(ExposeSchemaAsWebService.__messagetype_ExposeSchemaAsWebService_OutputSchema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ReceiveData_PT : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ReceiveData_PT(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ReceiveData_PT(ReceiveData_PT p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ReceiveData_PT p = new ReceiveData_PT(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Receive = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Receive",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(ReceiveData_PT),
            typeof(__messagetype_ExposeSchemaAsWebService_InputSchema),
            typeof(__messagetype_ExposeSchemaAsWebService_OutputSchema),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Receive" ] = Receive;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 136 "C:\Users\ramanarajan.d\OneDrive - MSC\BizTalk\POC\ExposeSchemaAsWebService\ExposeSchemaAsWebService\LoadData.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceiveData", "Receive", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        },
        new System.Type[] {
            typeof(ExposeSchemaAsWebService.ReceiveData_PT)
        },
        new System.String[] {
            "ReceiveData"
        },
        new System.Type[] {
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class LoadData : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(LoadData));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static LoadData()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __LoadData_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public LoadData(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "LoadData", tracker)
        {
            ConstructorHelper();
        }

        public LoadData(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "LoadData")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>814864e4-17b7-4d90-989a-42b5ad927fa4</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>b898ed45-4ad9-4d2f-bc70-7b07869d9ebd</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ReceiveData</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>e9d425bf-4614-4a50-af92-be40a0163956</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructData</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>70f5878a-aed1-4760-8b46-d896fdc9fe87</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>7dd5e647-a24c-4ca9-8a62-db1fbc719458</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>db5fc4e0-4b99-480d-8973-9da8406f859e</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>dd297922-59a3-43e1-8adc-842939dfccbf</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>b9933672-9e46-4f1f-bf82-13c77a5ffbf3</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>SendData</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'LoadData'</ActionName><IsAtomic>0</IsAtomic><Line>136</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>145</Line><Position>22</Position><ShapeID>'b898ed45-4ad9-4d2f-bc70-7b07869d9ebd'</ShapeID>
<Messages>
	<MsgInfo><name>ReceiveMsg</name><part>part</part><schema>ExposeSchemaAsWebService.InputSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>147</Line><Position>13</Position><ShapeID>'e9d425bf-4614-4a50-af92-be40a0163956'</ShapeID>
<Messages>
	<MsgInfo><name>SendMsg</name><part>part</part><schema>ExposeSchemaAsWebService.OutputSchema</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>ReceiveMsg</name><part>part</part><schema>ExposeSchemaAsWebService.InputSchema</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>153</Line><Position>13</Position><ShapeID>'b9933672-9e46-4f1f-bf82-13c77a5ffbf3'</ShapeID>
<Messages>
	<MsgInfo><name>SendMsg</name><part>part</part><schema>ExposeSchemaAsWebService.OutputSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='df1442be-1c58-4012-8fc2-5ff413666828' LowerBound='1.1' HigherBound='33.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='ExposeSchemaAsWebService' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='5272d67b-a92c-48b1-ad24-a7c233d54d15' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='32.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='LoadData' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='814864e4-17b7-4d90-989a-42b5ad927fa4' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='b898ed45-4ad9-4d2f-bc70-7b07869d9ebd' ParentLink='ServiceBody_Statement' LowerBound='20.1' HigherBound='22.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceiveData' />
                    <om:Property Name='MessageName' Value='ReceiveMsg' />
                    <om:Property Name='OperationName' Value='Receive' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ReceiveData' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='e9d425bf-4614-4a50-af92-be40a0163956' ParentLink='ServiceBody_Statement' LowerBound='22.1' HigherBound='28.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructData' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='70f5878a-aed1-4760-8b46-d896fdc9fe87' ParentLink='ComplexStatement_Statement' LowerBound='25.1' HigherBound='27.1'>
                        <om:Property Name='ClassName' Value='ExposeSchemaAsWebService.ConnectMap' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='7dd5e647-a24c-4ca9-8a62-db1fbc719458' ParentLink='Transform_InputMessagePartRef' LowerBound='26.76' HigherBound='26.86'>
                            <om:Property Name='MessageRef' Value='ReceiveMsg' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='db5fc4e0-4b99-480d-8973-9da8406f859e' ParentLink='Transform_OutputMessagePartRef' LowerBound='26.28' HigherBound='26.35'>
                            <om:Property Name='MessageRef' Value='SendMsg' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='dd297922-59a3-43e1-8adc-842939dfccbf' ParentLink='Construct_MessageRef' LowerBound='23.23' HigherBound='23.30'>
                        <om:Property Name='Ref' Value='SendMsg' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='b9933672-9e46-4f1f-bf82-13c77a5ffbf3' ParentLink='ServiceBody_Statement' LowerBound='28.1' HigherBound='30.1'>
                    <om:Property Name='PortName' Value='ReceiveData' />
                    <om:Property Name='MessageName' Value='SendMsg' />
                    <om:Property Name='OperationName' Value='Receive' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SendData' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='50fa8973-d8e8-44b9-b7ec-e12627a89c28' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='ExposeSchemaAsWebService.ReceiveData_PT' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveData' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='4cc66cda-5646-40f8-bc82-6fd553ced267' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='732e6ff2-4f2a-4280-b341-9849e717740e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='16.1' HigherBound='17.1'>
                <om:Property Name='Type' Value='ExposeSchemaAsWebService.InputSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='54cb9b69-b122-4b49-80dc-d1b1001313bc' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='17.1' HigherBound='18.1'>
                <om:Property Name='Type' Value='ExposeSchemaAsWebService.OutputSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='61d03389-4096-4fc9-ab3e-2c38eb4dab42' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ReceiveData_PT' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='ffc40122-e030-46db-9093-3d2542823d33' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Receive' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='54e92354-498b-48ab-8c9a-d3d2707b0458' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.24'>
                    <om:Property Name='Ref' Value='ExposeSchemaAsWebService.InputSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='4b33796c-fee7-44c3-bd58-ac29c814109a' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.26' HigherBound='8.38'>
                    <om:Property Name='Ref' Value='ExposeSchemaAsWebService.OutputSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __LoadData_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __LoadData_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "LoadData")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                LoadData __svc__ = (LoadData)_service;
                __LoadData_root_0 __ctx0__ = (__LoadData_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.ReceiveData != null)
                {
                    __svc__.ReceiveData.Close(this, null);
                    __svc__.ReceiveData = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __LoadData_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __LoadData_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "LoadData")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                LoadData __svc__ = (LoadData)_service;
                __LoadData_1 __ctx1__ = (__LoadData_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__SendMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SendMsg);
                    __ctx1__.__SendMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__ReceiveMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ReceiveMsg);
                    __ctx1__.__ReceiveMsg = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("ReceiveMsg")]
            public __messagetype_ExposeSchemaAsWebService_InputSchema __ReceiveMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SendMsg")]
            public __messagetype_ExposeSchemaAsWebService_OutputSchema __SendMsg;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceiveData")]
        internal ReceiveData_PT ReceiveData;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ReceiveData_PT.Receive},
                                               typeof(LoadData).GetField("ReceiveData", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(LoadData), "ReceiveData"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "b898ed45-4ad9-4d2f-bc70-7b07869d9ebd", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "b898ed45-4ad9-4d2f-bc70-7b07869d9ebd", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "e9d425bf-4614-4a50-af92-be40a0163956", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "e9d425bf-4614-4a50-af92-be40a0163956", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "b9933672-9e46-4f1f-bf82-13c77a5ffbf3", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "b9933672-9e46-4f1f-bf82-13c77a5ffbf3", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,7,7,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,7,7,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __LoadData_root_0 __ctx0__ = (__LoadData_root_0)_stateMgrs[0];
            __LoadData_1 __ctx1__ = (__LoadData_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                ReceiveData = new ReceiveData_PT(0, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ReceiveData, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __LoadData_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __LoadData_root_0 __ctx0__ = (__LoadData_root_0)_stateMgrs[0];
            __LoadData_1 __ctx1__ = (__LoadData_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!ReceiveData.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__ReceiveMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__ReceiveMsg);
                __ctx1__.__ReceiveMsg = new __messagetype_ExposeSchemaAsWebService_InputSchema("ReceiveMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__ReceiveMsg);
                ReceiveData.ReceiveMessage(0, __msgEnv__, __ctx1__.__ReceiveMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__ReceiveMsg);
                    __edata.PortName = @"ReceiveData";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    __messagetype_ExposeSchemaAsWebService_OutputSchema __SendMsg = new __messagetype_ExposeSchemaAsWebService_OutputSchema("SendMsg", __ctx1__);

                    ApplyTransform(typeof(ExposeSchemaAsWebService.ConnectMap), new object[] {__SendMsg.part}, new object[] {__ctx1__.__ReceiveMsg.part});

                    if (__ctx1__.__SendMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__SendMsg);
                    __ctx1__.__SendMsg = __SendMsg;
                    __ctx1__.RefMessage(__ctx1__.__SendMsg);
                }
                __ctx1__.__SendMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__SendMsg);
                    __edata.Messages.Add(__ctx1__.__ReceiveMsg);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__ReceiveMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ReceiveMsg);
                    __ctx1__.__ReceiveMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                ReceiveData.SendMessage(0, __ctx1__.__SendMsg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (ReceiveData != null)
                {
                    ReceiveData.Close(__ctx1__, __seg__);
                    ReceiveData = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__SendMsg);
                    __edata.PortName = @"ReceiveData";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__SendMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SendMsg);
                    __ctx1__.__SendMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 15;
            case 15:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __ExposeSchemaAsWebService_InputSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static ExposeSchemaAsWebService.InputSchema _schema = new ExposeSchemaAsWebService.InputSchema();

        public __ExposeSchemaAsWebService_InputSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "ExposeSchemaAsWebService.InputSchema",
        new System.Type[]{
            typeof(ExposeSchemaAsWebService.InputSchema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__ExposeSchemaAsWebService_InputSchema__)
        },
        0,
        @"http://ExposeSchemaAsWebService.InputSchema#Data"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_ExposeSchemaAsWebService_InputSchema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __ExposeSchemaAsWebService_InputSchema__ part;

        private void __CreatePartWrappers()
        {
            part = new __ExposeSchemaAsWebService_InputSchema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_ExposeSchemaAsWebService_InputSchema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __ExposeSchemaAsWebService_OutputSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static ExposeSchemaAsWebService.OutputSchema _schema = new ExposeSchemaAsWebService.OutputSchema();

        public __ExposeSchemaAsWebService_OutputSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "ExposeSchemaAsWebService.OutputSchema",
        new System.Type[]{
            typeof(ExposeSchemaAsWebService.OutputSchema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__ExposeSchemaAsWebService_OutputSchema__)
        },
        0,
        @"http://ExposeSchemaAsWebService.OutputSchema#Details"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_ExposeSchemaAsWebService_OutputSchema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __ExposeSchemaAsWebService_OutputSchema__ part;

        private void __CreatePartWrappers()
        {
            part = new __ExposeSchemaAsWebService_OutputSchema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_ExposeSchemaAsWebService_OutputSchema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}

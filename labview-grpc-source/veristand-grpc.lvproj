<?xml version='1.0' encoding='UTF-8'?>
<Project Type="Project" LVVersion="20008000">
	<Item Name="My Computer" Type="My Computer">
		<Property Name="server.app.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.control.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.tcp.enabled" Type="Bool">false</Property>
		<Property Name="server.tcp.port" Type="Int">0</Property>
		<Property Name="server.tcp.serviceName" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.tcp.serviceName.default" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.vi.callsEnabled" Type="Bool">true</Property>
		<Property Name="server.vi.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="specify.custom.address" Type="Bool">false</Property>
		<Item Name="Utility" Type="Folder">
			<Item Name="Post-Build Action.vi" Type="VI" URL="../Utility/Post-Build Action.vi"/>
		</Item>
		<Item Name="veristand-grpc_client" Type="Folder">
			<Item Name="VeriStandgrpc_client.lvlib" Type="Library" URL="../veristand-grpc_client/VeriStandgrpc_client.lvlib"/>
		</Item>
		<Item Name="veristand-grpc_server" Type="Folder">
			<Item Name="Veristandgrpc_server.lvlib" Type="Library" URL="../veristand-grpc_server/Veristandgrpc_server.lvlib"/>
		</Item>
		<Item Name="Dependencies" Type="Dependencies">
			<Item Name="vi.lib" Type="Folder">
				<Item Name="1D String Array to Delimited String.vi" Type="VI" URL="/&lt;vilib&gt;/AdvancedString/1D String Array to Delimited String.vi"/>
				<Item Name="Application Directory.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/file.llb/Application Directory.vi"/>
				<Item Name="BuildHelpPath.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/BuildHelpPath.vi"/>
				<Item Name="Check Special Tags.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Check Special Tags.vi"/>
				<Item Name="Clear Errors.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Clear Errors.vi"/>
				<Item Name="Convert property node font to graphics font.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Convert property node font to graphics font.vi"/>
				<Item Name="Details Display Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Details Display Dialog.vi"/>
				<Item Name="DialogType.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/DialogType.ctl"/>
				<Item Name="DialogTypeEnum.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/DialogTypeEnum.ctl"/>
				<Item Name="Error Cluster From Error Code.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Error Cluster From Error Code.vi"/>
				<Item Name="Error Code Database.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Error Code Database.vi"/>
				<Item Name="ErrWarn.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/ErrWarn.ctl"/>
				<Item Name="eventvkey.ctl" Type="VI" URL="/&lt;vilib&gt;/event_ctls.llb/eventvkey.ctl"/>
				<Item Name="Find Tag.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Find Tag.vi"/>
				<Item Name="Format Message String.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Format Message String.vi"/>
				<Item Name="General Error Handler Core CORE.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/General Error Handler Core CORE.vi"/>
				<Item Name="General Error Handler.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/General Error Handler.vi"/>
				<Item Name="Get String Text Bounds.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Get String Text Bounds.vi"/>
				<Item Name="Get System Directory.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/sysdir.llb/Get System Directory.vi"/>
				<Item Name="Get Text Rect.vi" Type="VI" URL="/&lt;vilib&gt;/picture/picture.llb/Get Text Rect.vi"/>
				<Item Name="GetHelpDir.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/GetHelpDir.vi"/>
				<Item Name="GetRTHostConnectedProp.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/GetRTHostConnectedProp.vi"/>
				<Item Name="grpc-lvsupport-release.lvlib" Type="Library" URL="/&lt;vilib&gt;/gRPC/LabVIEW gRPC Library/grpc-lvsupport-release.lvlib"/>
				<Item Name="gRPC-servicer-release.lvlib" Type="Library" URL="/&lt;vilib&gt;/gRPC/LabVIEW gRPC Servicer/gRPC-servicer-release.lvlib"/>
				<Item Name="Longest Line Length in Pixels.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Longest Line Length in Pixels.vi"/>
				<Item Name="LVBoundsTypeDef.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/miscctls.llb/LVBoundsTypeDef.ctl"/>
				<Item Name="LVRectTypeDef.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/miscctls.llb/LVRectTypeDef.ctl"/>
				<Item Name="NI_FileType.lvlib" Type="Library" URL="/&lt;vilib&gt;/Utility/lvfile.llb/NI_FileType.lvlib"/>
				<Item Name="NI_PackedLibraryUtility.lvlib" Type="Library" URL="/&lt;vilib&gt;/Utility/LVLibp/NI_PackedLibraryUtility.lvlib"/>
				<Item Name="Not Found Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Not Found Dialog.vi"/>
				<Item Name="Search and Replace Pattern.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Search and Replace Pattern.vi"/>
				<Item Name="Set Bold Text.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Set Bold Text.vi"/>
				<Item Name="Set String Value.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Set String Value.vi"/>
				<Item Name="Simple Error Handler.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Simple Error Handler.vi"/>
				<Item Name="System Directory Type.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/sysdir.llb/System Directory Type.ctl"/>
				<Item Name="TagReturnType.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/TagReturnType.ctl"/>
				<Item Name="Three Button Dialog CORE.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Three Button Dialog CORE.vi"/>
				<Item Name="Three Button Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Three Button Dialog.vi"/>
				<Item Name="Trim Whitespace.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Trim Whitespace.vi"/>
				<Item Name="whitespace.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/whitespace.ctl"/>
			</Item>
		</Item>
		<Item Name="Build Specifications" Type="Build">
			<Item Name="lvgrpcClientAssembly" Type=".NET Interop Assembly">
				<Property Name="App_copyErrors" Type="Bool">true</Property>
				<Property Name="App_INI_aliasGUID" Type="Str">{0D51D3D3-1F56-4BE0-ACF1-6075D42681A0}</Property>
				<Property Name="App_INI_GUID" Type="Str">{7061D809-DB2C-409B-A0E1-7844212219C6}</Property>
				<Property Name="App_serverConfig.httpPort" Type="Int">8002</Property>
				<Property Name="App_serverType" Type="Int">0</Property>
				<Property Name="Bld_autoIncrement" Type="Bool">true</Property>
				<Property Name="Bld_buildCacheID" Type="Str">{77C305EA-0E2D-4EE2-B7A2-0EE612DCE10B}</Property>
				<Property Name="Bld_buildSpecName" Type="Str">lvgrpcClientAssembly</Property>
				<Property Name="Bld_excludeInlineSubVIs" Type="Bool">true</Property>
				<Property Name="Bld_excludeLibraryItems" Type="Bool">true</Property>
				<Property Name="Bld_excludePolymorphicVIs" Type="Bool">true</Property>
				<Property Name="Bld_localDestDir" Type="Path">../BuiltAssembly</Property>
				<Property Name="Bld_localDestDirType" Type="Str">relativeToCommon</Property>
				<Property Name="Bld_modifyLibraryFile" Type="Bool">true</Property>
				<Property Name="Bld_postActionVIID" Type="Ref">/My Computer/Utility/Post-Build Action.vi</Property>
				<Property Name="Bld_previewCacheID" Type="Str">{31BC2E79-1879-42AF-95C4-12B6BDD0BB7D}</Property>
				<Property Name="Bld_version.build" Type="Int">6</Property>
				<Property Name="Bld_version.major" Type="Int">1</Property>
				<Property Name="Destination[0].destName" Type="Str">lvgrpc.dll</Property>
				<Property Name="Destination[0].path" Type="Path">../BuiltAssembly/lvgrpc.dll</Property>
				<Property Name="Destination[0].preserveHierarchy" Type="Bool">true</Property>
				<Property Name="Destination[0].type" Type="Str">App</Property>
				<Property Name="Destination[1].destName" Type="Str">Support Directory</Property>
				<Property Name="Destination[1].path" Type="Path">../BuiltAssembly/data</Property>
				<Property Name="DestinationCount" Type="Int">2</Property>
				<Property Name="DotNET2011CompatibilityMode" Type="Bool">false</Property>
				<Property Name="DotNETAssembly_ClassName" Type="Str">LabVIEWExports</Property>
				<Property Name="DotNETAssembly_delayOSMsg" Type="Bool">true</Property>
				<Property Name="DotNETAssembly_Namespace" Type="Str">LabVIEW.gRPC</Property>
				<Property Name="DotNETAssembly_signAssembly" Type="Bool">false</Property>
				<Property Name="DotNETAssembly_StrongNameKeyFileItemID" Type="Ref"></Property>
				<Property Name="DotNETAssembly_StrongNameKeyGUID" Type="Str">{F13F7487-AB63-4260-872E-BCF20C50F836}</Property>
				<Property Name="Source[0].itemID" Type="Str">{0E8F8D58-7CBC-4A9E-AD5B-A403AB26D2CD}</Property>
				<Property Name="Source[0].type" Type="Str">Container</Property>
				<Property Name="Source[1].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[0]VIProtoConNum" Type="Int">-1</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[0]VIProtoDataType" Type="Str">void</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[0]VIProtoDir" Type="Int">1</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[0]VIProtoIutputIdx" Type="Int">-1</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[0]VIProtoName" Type="Str">returnvalue</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[0]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[1]VIProtoConNum" Type="Int">11</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[1]VIProtoDataType" Type="Str">String</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[1]VIProtoDir" Type="Int">0</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[1]VIProtoIutputIdx" Type="Int">11</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[1]VIProtoName" Type="Str">address</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[1]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[2]VIProtoConNum" Type="Int">10</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[2]VIProtoDataType" Type="Str">String</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[2]VIProtoDir" Type="Int">0</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[2]VIProtoIutputIdx" Type="Int">10</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[2]VIProtoName" Type="Str">certificatePath</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[2]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[3]VIProtoConNum" Type="Int">3</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[3]VIProtoDataType" Type="Str">U64</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[3]VIProtoDir" Type="Int">1</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[3]VIProtoIutputIdx" Type="Int">-1</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[3]VIProtoName" Type="Str">grpc_Id</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[3]VIProtoOutputIdx" Type="Int">3</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[4]VIProtoConNum" Type="Int">8</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[4]VIProtoDataType" Type="Str">Cluster</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[4]VIProtoDir" Type="Int">6</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[4]VIProtoIutputIdx" Type="Int">8</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[4]VIProtoName" Type="Str">error__32in</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[4]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[5]MethodName" Type="Str">CreateClient</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[5]VIName" Type="Str">Create Client.vi</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[5]VIProtoConNum" Type="Int">0</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[5]VIProtoDataType" Type="Str">Cluster</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[5]VIProtoDir" Type="Int">7</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[5]VIProtoIutputIdx" Type="Int">-1</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[5]VIProtoName" Type="Str">error__32out</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfo[5]VIProtoOutputIdx" Type="Int">0</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfoVIDocumentation" Type="Str"></Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfoVIDocumentationEnabled" Type="Int">0</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfoVIIsNamesSanitized" Type="Int">1</Property>
				<Property Name="Source[1].ExportedAssemblyVI.VIProtoInfoVIProtoItemCount" Type="Int">6</Property>
				<Property Name="Source[1].itemID" Type="Ref">/My Computer/veristand-grpc_client/VeriStandgrpc_client.lvlib/Client API/Create Client.vi</Property>
				<Property Name="Source[1].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[1].type" Type="Str">ExportedAssemblyVI</Property>
				<Property Name="Source[2].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[0]VIProtoConNum" Type="Int">-1</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[0]VIProtoDataType" Type="Str">void</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[0]VIProtoDir" Type="Int">1</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[0]VIProtoIutputIdx" Type="Int">-1</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[0]VIProtoName" Type="Str">returnvalue</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[0]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[1]VIProtoConNum" Type="Int">11</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[1]VIProtoDataType" Type="Str">U64</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[1]VIProtoDir" Type="Int">0</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[1]VIProtoIutputIdx" Type="Int">11</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[1]VIProtoName" Type="Str">grpc_Id</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[1]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[2]VIProtoConNum" Type="Int">8</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[2]VIProtoDataType" Type="Str">Cluster</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[2]VIProtoDir" Type="Int">6</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[2]VIProtoIutputIdx" Type="Int">8</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[2]VIProtoName" Type="Str">error__32in</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[2]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[3]MethodName" Type="Str">DestroyClient</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[3]VIName" Type="Str">Destroy Client.vi</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[3]VIProtoConNum" Type="Int">0</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[3]VIProtoDataType" Type="Str">Cluster</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[3]VIProtoDir" Type="Int">7</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[3]VIProtoIutputIdx" Type="Int">-1</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[3]VIProtoName" Type="Str">error__32out</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfo[3]VIProtoOutputIdx" Type="Int">0</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfoVIDocumentation" Type="Str"></Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfoVIDocumentationEnabled" Type="Int">0</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfoVIIsNamesSanitized" Type="Int">1</Property>
				<Property Name="Source[2].ExportedAssemblyVI.VIProtoInfoVIProtoItemCount" Type="Int">4</Property>
				<Property Name="Source[2].itemID" Type="Ref">/My Computer/veristand-grpc_client/VeriStandgrpc_client.lvlib/Client API/Destroy Client.vi</Property>
				<Property Name="Source[2].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[2].type" Type="Str">ExportedAssemblyVI</Property>
				<Property Name="Source[3].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[0]VIProtoConNum" Type="Int">-1</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[0]VIProtoDataType" Type="Str">void</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[0]VIProtoDir" Type="Int">1</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[0]VIProtoIutputIdx" Type="Int">-1</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[0]VIProtoName" Type="Str">returnvalue</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[0]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[1]VIProtoConNum" Type="Int">11</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[1]VIProtoDataType" Type="Str">U64</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[1]VIProtoDir" Type="Int">0</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[1]VIProtoIutputIdx" Type="Int">11</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[1]VIProtoName" Type="Str">grpc_Id</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[1]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[2]VIProtoConNum" Type="Int">10</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[2]VIProtoDataType" Type="Str">Cluster</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[2]VIProtoDir" Type="Int">0</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[2]VIProtoIutputIdx" Type="Int">10</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[2]VIProtoName" Type="Str">RequestData</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[2]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[3]VIProtoConNum" Type="Int">2</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[3]VIProtoDataType" Type="Str">Cluster</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[3]VIProtoDir" Type="Int">1</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[3]VIProtoIutputIdx" Type="Int">-1</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[3]VIProtoName" Type="Str">ResponseData</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[3]VIProtoOutputIdx" Type="Int">2</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[4]VIProtoConNum" Type="Int">9</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[4]VIProtoDataType" Type="Str">I32</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[4]VIProtoDir" Type="Int">0</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[4]VIProtoIutputIdx" Type="Int">9</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[4]VIProtoName" Type="Str">timeout_ms</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[4]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[5]VIProtoConNum" Type="Int">6</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[5]VIProtoDataType" Type="Str">U64</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[5]VIProtoDir" Type="Int">0</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[5]VIProtoIutputIdx" Type="Int">6</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[5]VIProtoName" Type="Str">contextId</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[5]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[6]VIProtoConNum" Type="Int">3</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[6]VIProtoDataType" Type="Str">U64</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[6]VIProtoDir" Type="Int">4</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[6]VIProtoIutputIdx" Type="Int">-1</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[6]VIProtoName" Type="Str">gRPC__32ID__32out</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[6]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[7]VIProtoConNum" Type="Int">8</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[7]VIProtoDataType" Type="Str">Cluster</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[7]VIProtoDir" Type="Int">6</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[7]VIProtoIutputIdx" Type="Int">8</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[7]VIProtoName" Type="Str">error__32in</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[7]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[8]MethodName" Type="Str">GrpcWrite</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[8]VIName" Type="Str">veristand Write.vi</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[8]VIProtoConNum" Type="Int">0</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[8]VIProtoDataType" Type="Str">Cluster</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[8]VIProtoDir" Type="Int">7</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[8]VIProtoIutputIdx" Type="Int">-1</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[8]VIProtoName" Type="Str">error__32out</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfo[8]VIProtoOutputIdx" Type="Int">0</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfoVIDocumentation" Type="Str"></Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfoVIDocumentationEnabled" Type="Int">0</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfoVIIsNamesSanitized" Type="Int">1</Property>
				<Property Name="Source[3].ExportedAssemblyVI.VIProtoInfoVIProtoItemCount" Type="Int">9</Property>
				<Property Name="Source[3].itemID" Type="Ref">/My Computer/veristand-grpc_client/VeriStandgrpc_client.lvlib/RPC Service/veristand/veristand Write/veristand Write.vi</Property>
				<Property Name="Source[3].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[3].type" Type="Str">ExportedAssemblyVI</Property>
				<Property Name="Source[4].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[0]VIProtoConNum" Type="Int">-1</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[0]VIProtoDataType" Type="Str">void</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[0]VIProtoDir" Type="Int">1</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[0]VIProtoIutputIdx" Type="Int">-1</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[0]VIProtoName" Type="Str">returnvalue</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[0]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[1]VIProtoConNum" Type="Int">11</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[1]VIProtoDataType" Type="Str">U64</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[1]VIProtoDir" Type="Int">0</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[1]VIProtoIutputIdx" Type="Int">11</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[1]VIProtoName" Type="Str">grpc_Id</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[1]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[2]VIProtoConNum" Type="Int">10</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[2]VIProtoDataType" Type="Str">Cluster</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[2]VIProtoDir" Type="Int">0</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[2]VIProtoIutputIdx" Type="Int">10</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[2]VIProtoName" Type="Str">RequestData</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[2]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[3]VIProtoConNum" Type="Int">2</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[3]VIProtoDataType" Type="Str">Cluster</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[3]VIProtoDir" Type="Int">1</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[3]VIProtoIutputIdx" Type="Int">-1</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[3]VIProtoName" Type="Str">ResponseData</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[3]VIProtoOutputIdx" Type="Int">2</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[4]VIProtoConNum" Type="Int">9</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[4]VIProtoDataType" Type="Str">I32</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[4]VIProtoDir" Type="Int">0</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[4]VIProtoIutputIdx" Type="Int">9</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[4]VIProtoName" Type="Str">timeout_ms</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[4]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[5]VIProtoConNum" Type="Int">6</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[5]VIProtoDataType" Type="Str">U64</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[5]VIProtoDir" Type="Int">0</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[5]VIProtoIutputIdx" Type="Int">6</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[5]VIProtoName" Type="Str">contextId</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[5]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[6]VIProtoConNum" Type="Int">3</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[6]VIProtoDataType" Type="Str">U64</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[6]VIProtoDir" Type="Int">4</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[6]VIProtoIutputIdx" Type="Int">-1</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[6]VIProtoName" Type="Str">gRPC__32ID__32out</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[6]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[7]VIProtoConNum" Type="Int">8</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[7]VIProtoDataType" Type="Str">Cluster</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[7]VIProtoDir" Type="Int">6</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[7]VIProtoIutputIdx" Type="Int">8</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[7]VIProtoName" Type="Str">error__32in</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[7]VIProtoOutputIdx" Type="Int">-1</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[8]MethodName" Type="Str">GrpcRead</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[8]VIName" Type="Str">veristand Read.vi</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[8]VIProtoConNum" Type="Int">0</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[8]VIProtoDataType" Type="Str">Cluster</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[8]VIProtoDir" Type="Int">7</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[8]VIProtoIutputIdx" Type="Int">-1</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[8]VIProtoName" Type="Str">error__32out</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfo[8]VIProtoOutputIdx" Type="Int">0</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfoVIDocumentation" Type="Str"></Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfoVIDocumentationEnabled" Type="Int">0</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfoVIIsNamesSanitized" Type="Int">1</Property>
				<Property Name="Source[4].ExportedAssemblyVI.VIProtoInfoVIProtoItemCount" Type="Int">9</Property>
				<Property Name="Source[4].itemID" Type="Ref">/My Computer/veristand-grpc_client/VeriStandgrpc_client.lvlib/RPC Service/veristand/veristand Read/veristand Read.vi</Property>
				<Property Name="Source[4].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[4].type" Type="Str">ExportedAssemblyVI</Property>
				<Property Name="SourceCount" Type="Int">5</Property>
				<Property Name="TgtF_fileDescription" Type="Str">lvgrpcClientAssembly</Property>
				<Property Name="TgtF_internalName" Type="Str">lvgrpcClientAssembly</Property>
				<Property Name="TgtF_legalCopyright" Type="Str">Copyright ?2023 </Property>
				<Property Name="TgtF_productName" Type="Str">lvgrpcClientAssembly</Property>
				<Property Name="TgtF_targetfileGUID" Type="Str">{5BBEC81D-6E5D-4228-8A1F-C5DFCBA4765C}</Property>
				<Property Name="TgtF_targetfileName" Type="Str">lvgrpc.dll</Property>
				<Property Name="TgtF_versionIndependent" Type="Bool">true</Property>
			</Item>
		</Item>
	</Item>
</Project>

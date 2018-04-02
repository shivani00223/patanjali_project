<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{91CA73B0-AD0A-4DB5-BDA4-37D61E4B96D4}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <StartupObject>WindowsApplication15.My.MyApplication</StartupObject>
    <RootNamespace>WindowsApplication15</RootNamespace>
    <AssemblyName>WindowsApplication15</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>WindowsForms</MyType>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <TargetFrameworkProfile>Client</TargetFrameworkProfile>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>WindowsApplication15.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>WindowsApplication15.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup>
    <OptionExplicit>On</OptionExplicit>
  </PropertyGroup>
  <PropertyGroup>
    <OptionCompare>Binary</OptionCompare>
  </PropertyGroup>
  <PropertyGroup>
    <OptionStrict>Off</OptionStrict>
  </PropertyGroup>
  <PropertyGroup>
    <OptionInfer>On</OptionInfer>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Drawing" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Windows.Forms" />
    <Import Include="System.Linq" />
    <Import Include="System.Xml.Linq" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="agervati.Designer.vb">
      <DependentUpon>agervati.vb</DependentUpon>
    </Compile>
    <Compile Include="agervati.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="arishta.Designer.vb">
      <DependentUpon>arishta.vb</DependentUpon>
    </Compile>
    <Compile Include="arishta.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="asva.Designer.vb">
      <DependentUpon>asva.vb</DependentUpon>
    </Compile>
    <Compile Include="asva.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="bdam.Designer.vb">
      <DependentUpon>bdam.vb</DependentUpon>
    </Compile>
    <Compile Include="bdam.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="bes.Designer.vb">
      <DependentUpon>bes.vb</DependentUpon>
    </Compile>
    <Compile Include="bes.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="bodycare.Designer.vb">
      <DependentUpon>bodycare.vb</DependentUpon>
    </Compile>
    <Compile Include="bodycare.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="BROKEN.Designer.vb">
      <DependentUpon>BROKEN.vb</DependentUpon>
    </Compile>
    <Compile Include="BROKEN.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="BURA.Designer.vb">
      <DependentUpon>BURA.vb</DependentUpon>
    </Compile>
    <Compile Include="BURA.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="candy.Designer.vb">
      <DependentUpon>candy.vb</DependentUpon>
    </Compile>
    <Compile Include="candy.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="CF.Designer.vb">
      <DependentUpon>CF.vb</DependentUpon>
    </Compile>
    <Compile Include="CF.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="chy.Designer.vb">
      <DependentUpon>chy.vb</DependentUpon>
    </Compile>
    <Compile Include="chy.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="condi.Designer.vb">
      <DependentUpon>condi.vb</DependentUpon>
    </Compile>
    <Compile Include="condi.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="detergentpowder.Designer.vb">
      <DependentUpon>detergentpowder.vb</DependentUpon>
    </Compile>
    <Compile Include="detergentpowder.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="dig.Designer.vb">
      <DependentUpon>dig.vb</DependentUpon>
    </Compile>
    <Compile Include="dig.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="dishwash.Designer.vb">
      <DependentUpon>dishwash.vb</DependentUpon>
    </Compile>
    <Compile Include="dishwash.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="eye.Designer.vb">
      <DependentUpon>eye.vb</DependentUpon>
    </Compile>
    <Compile Include="eye.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="facepack.Designer.vb">
      <DependentUpon>facepack.vb</DependentUpon>
    </Compile>
    <Compile Include="facepack.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="fj.Designer.vb">
      <DependentUpon>fj.vb</DependentUpon>
    </Compile>
    <Compile Include="fj.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="bhsma.Designer.vb">
      <DependentUpon>bhsma.vb</DependentUpon>
    </Compile>
    <Compile Include="bhsma.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Footcream.Designer.vb">
      <DependentUpon>Footcream.vb</DependentUpon>
    </Compile>
    <Compile Include="Footcream.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="ghi.Designer.vb">
      <DependentUpon>ghi.vb</DependentUpon>
    </Compile>
    <Compile Include="ghi.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="godhrk.Designer.vb">
      <DependentUpon>godhrk.vb</DependentUpon>
    </Compile>
    <Compile Include="godhrk.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="gram.Designer.vb">
      <DependentUpon>gram.vb</DependentUpon>
    </Compile>
    <Compile Include="gram.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="GUGUL.Designer.vb">
      <DependentUpon>GUGUL.vb</DependentUpon>
    </Compile>
    <Compile Include="GUGUL.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="hawan.Designer.vb">
      <DependentUpon>hawan.vb</DependentUpon>
    </Compile>
    <Compile Include="hawan.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="hd.Designer.vb">
      <DependentUpon>hd.vb</DependentUpon>
    </Compile>
    <Compile Include="hd.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="herbalTea.Designer.vb">
      <DependentUpon>herbalTea.vb</DependentUpon>
    </Compile>
    <Compile Include="herbalTea.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="hm.Designer.vb">
      <DependentUpon>hm.vb</DependentUpon>
    </Compile>
    <Compile Include="hm.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="hon.Designer.vb">
      <DependentUpon>hon.vb</DependentUpon>
    </Compile>
    <Compile Include="hon.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="hw.Designer.vb">
      <DependentUpon>hw.vb</DependentUpon>
    </Compile>
    <Compile Include="hw.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="jm.Designer.vb">
      <DependentUpon>jm.vb</DependentUpon>
    </Compile>
    <Compile Include="jm.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="kwath.Designer.vb">
      <DependentUpon>kwath.vb</DependentUpon>
    </Compile>
    <Compile Include="kwath.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="lt.Designer.vb">
      <DependentUpon>lt.vb</DependentUpon>
    </Compile>
    <Compile Include="lt.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="M0IL.Designer.vb">
      <DependentUpon>M0IL.vb</DependentUpon>
    </Compile>
    <Compile Include="M0IL.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="medic.Designer.vb">
      <DependentUpon>medic.vb</DependentUpon>
    </Compile>
    <Compile Include="medic.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="murrabA.Designer.vb">
      <DependentUpon>murrabA.vb</DependentUpon>
    </Compile>
    <Compile Include="murrabA.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="NOODLES.Designer.VB">
      <DependentUpon>NOODLES.VB</DependentUpon>
    </Compile>
    <Compile Include="NOODLES.VB">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Oatsvb.Designer.vb">
      <DependentUpon>Oatsvb.vb</DependentUpon>
    </Compile>
    <Compile Include="Oatsvb.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="papad.Designer.vb">
      <DependentUpon>papad.vb</DependentUpon>
    </Compile>
    <Compile Include="papad.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="parpati.Designer.vb">
      <DependentUpon>parpati.vb</DependentUpon>
    </Compile>
    <Compile Include="parpati.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="patanjalchuran.Designer.vb">
      <DependentUpon>patanjalchuran.vb</DependentUpon>
    </Compile>
    <Compile Include="patanjalchuran.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="patanjlioil.Designer.vb">
      <DependentUpon>patanjlioil.vb</DependentUpon>
    </Compile>
    <Compile Include="patanjlioil.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="pers.Designer.vb">
      <DependentUpon>pers.vb</DependentUpon>
    </Compile>
    <Compile Include="pers.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="groc.Designer.vb">
      <DependentUpon>groc.vb</DependentUpon>
    </Compile>
    <Compile Include="groc.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="h.Designer.vb">
      <DependentUpon>h.vb</DependentUpon>
    </Compile>
    <Compile Include="h.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="mainpage.Designer.vb">
      <DependentUpon>mainpage.vb</DependentUpon>
    </Compile>
    <Compile Include="mainpage.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="login.Designer.vb">
      <DependentUpon>login.vb</DependentUpon>
    </Compile>
    <Compile Include="login.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="My Project\AssemblyInfo.vb" />
    <Compile Include="My Project\Application.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Application.myapp</DependentUpon>
    </Compile>
    <Compile Include="My Project\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <Compile Include="My Project\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
    <Compile Include="pic.Designer.vb">
      <DependentUpon>pic.vb</DependentUpon>
    </Compile>
    <Compile Include="pic.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="pishti.Designer.vb">
      <DependentUpon>pishti.vb</DependentUpon>
    </Compile>
    <Compile Include="pishti.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="PULSES.Designer.VB">
      <DependentUpon>PULSES.VB</DependentUpon>
    </Compile>
    <Compile Include="PULSES.VB">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="reg.Designer.vb">
      <DependentUpon>reg.vb</DependentUpon>
    </Compile>
    <Compile Include="reg.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="RICE.Designer.VB">
      <DependentUpon>RICE.VB</DependentUpon>
    </Compile>
    <Compile Include="RICE.VB">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="shampoo.Designer.vb">
      <DependentUpon>shampoo.vb</DependentUpon>
    </Compile>
    <Compile Include="shampoo.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="shaving.Designer.vb">
      <DependentUpon>shaving.vb</DependentUpon>
    </Compile>
    <Compile Include="shaving.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="skincare.Designer.vb">
      <DependentUpon>skincare.vb</DependentUpon>
    </Compile>
    <Compile Include="skincare.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="SOAN.Designer.vb">
      <DependentUpon>SOAN.vb</DependentUpon>
    </Compile>
    <Compile Include="SOAN.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="soap.Designer.vb">
      <DependentUpon>soap.vb</DependentUpon>
    </Compile>
    <Compile Include="soap.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="spice.Designer.vb">
      <DependentUpon>spice.vb</DependentUpon>
    </Compile>
    <Compile Include="spice.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="SUGER.Designer.vb">
      <DependentUpon>SUGER.vb</DependentUpon>
    </Compile>
    <Compile Include="SUGER.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="syrup.Designer.vb">
      <DependentUpon>syrup.vb</DependentUpon>
    </Compile>
    <Compile Include="syrup.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="toothbrush.Designer.vb">
      <DependentUpon>toothbrush.vb</DependentUpon>
    </Compile>
    <Compile Include="toothbrush.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="toothpaste.Designer.vb">
      <DependentUpon>toothpaste.vb</DependentUpon>
    </Compile>
    <Compile Include="toothpaste.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="toothpowder.Designer.vb">
      <DependentUpon>toothpowder.vb</DependentUpon>
    </Compile>
    <Compile Include="toothpowder.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="vati.Designer.vb">
      <DependentUpon>vati.vb</DependentUpon>
    </Compile>
    <Compile Include="vati.vb">
      <SubType>Form</SubType>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="agervati.resx">
      <DependentUpon>agervati.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="arishta.resx">
      <DependentUpon>arishta.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="asva.resx">
      <DependentUpon>asva.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="bdam.resx">
      <DependentUpon>bdam.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="bes.resx">
      <DependentUpon>bes.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="bodycare.resx">
      <DependentUpon>bodycare.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="BROKEN.resx">
      <DependentUpon>BROKEN.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="BURA.resx">
      <DependentUpon>BURA.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="candy.resx">
      <DependentUpon>candy.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="CF.resx">
      <DependentUpon>CF.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="chy.resx">
      <DependentUpon>chy.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="condi.resx">
      <DependentUpon>condi.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="dig.resx">
      <DependentUpon>dig.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="dishwash.resx">
      <DependentUpon>dishwash.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="eye.resx">
      <DependentUpon>eye.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="facepack.resx">
      <DependentUpon>facepack.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="fj.resx">
      <DependentUpon>fj.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="bhsma.resx">
      <DependentUpon>bhsma.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Footcream.resx">
      <DependentUpon>Footcream.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="ghi.resx">
      <DependentUpon>ghi.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="godhrk.resx">
      <DependentUpon>godhrk.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="gram.resx">
      <DependentUpon>gram.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="GUGUL.resx">
      <DependentUpon>GUGUL.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="hd.resx">
      <DependentUpon>hd.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="herbalTea.resx">
      <DependentUpon>herbalTea.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="hm.resx">
      <DependentUpon>hm.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="hon.resx">
      <DependentUpon>hon.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="hw.resx">
      <DependentUpon>hw.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="jm.resx">
      <DependentUpon>jm.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="kwath.resx">
      <DependentUpon>kwath.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="lt.resx">
      <DependentUpon>lt.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="M0IL.resx">
      <DependentUpon>M0IL.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="medic.resx">
      <DependentUpon>medic.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="groc.resx">
      <DependentUpon>groc.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="h.resx">
      <DependentUpon>h.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="mainpage.resx">
      <DependentUpon>mainpage.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="login.resx">
      <DependentUpon>login.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="murrabA.resx">
      <DependentUpon>murrabA.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="My Project\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include="NOODLES.resx">
      <DependentUpon>NOODLES.VB</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Oatsvb.resx">
      <DependentUpon>Oatsvb.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="papad.resx">
      <DependentUpon>papad.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="parpati.resx">
      <DependentUpon>parpati.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="patanjalchuran.resx">
      <DependentUpon>patanjalchuran.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="patanjlioil.resx">
      <DependentUpon>patanjlioil.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="pers.resx">
      <DependentUpon>pers.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="pic.resx">
      <DependentUpon>pic.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="pishti.resx">
      <DependentUpon>pishti.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="PULSES.resx">
      <DependentUpon>PULSES.VB</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="reg.resx">
      <DependentUpon>reg.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="RICE.resx">
      <DependentUpon>RICE.VB</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="shampoo.resx">
      <DependentUpon>shampoo.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="shaving.resx">
      <DependentUpon>shaving.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="skincare.resx">
      <DependentUpon>skincare.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="SOAN.resx">
      <DependentUpon>SOAN.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="soap.resx">
      <DependentUpon>soap.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="spice.resx">
      <DependentUpon>spice.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="SUGER.resx">
      <DependentUpon>SUGER.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="syrup.resx">
      <DependentUpon>syrup.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="toothbrush.resx">
      <DependentUpon>toothbrush.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="toothpaste.resx">
      <DependentUpon>toothpaste.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="toothpowder.resx">
      <DependentUpon>toothpowder.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="vati.resx">
      <DependentUpon>vati.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="images\shivani\img.w\4070493-cats-in-winter-wallpaper - Shortcut.lnk" />
    <None Include="images\shivani\img.w\day-001-login-form.webp" />
    <None Include="My Project\Application.myapp">
      <Generator>MyApplicationCodeGenerator</Generator>
      <LastGenOutput>Application.Designer.vb</LastGenOutput>
    </None>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <CustomToolNamespace>My</CustomToolNamespace>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
  </ItemGroup>
  <ItemGroup>
    <Folder Include="Resources\" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="images\shivani\11-Patanjali-Neem-Kanti-Body-Cleanser-Soap-1.jpg" />
    <Content Include="images\shivani\13047-patanjali-fssai.jpg" />
    <Content Include="images\shivani\925790092s.png" />
    <Content Include="images\shivani\bunch.png" />
    <Content Include="images\shivani\butterflies_texture_background_pattern_9681_2560x1600.jpg" />
    <Content Include="images\shivani\img.w\1046390-winter-wallpaper-hd.jpg" />
    <Content Include="images\shivani\img.w\1469089961cfd991c6d9f609d5e6584a69287d5a39.jpg" />
    <Content Include="images\shivani\img.w\17023.jpg" />
    <Content Include="images\shivani\img.w\3574641-transparent-wallpapers.jpg" />
    <Content Include="images\shivani\img.w\3d-digital-design-widescreen-wallpaper_1920x1200_86479.jpg" />
    <Content Include="images\shivani\img.w\3d-simple-background-wallpapers-hd--desktop-and-mobile-backgrounds-18.jpeg" />
    <Content Include="images\shivani\img.w\4070493-cats-in-winter-wallpaper.jpg" />
    <Content Include="images\shivani\img.w\4ae8c9fccd882109292886398e30b1e8--iphone--wallpaper-wallpaper-backgrounds.jpg" />
    <Content Include="images\shivani\img.w\554659-3d-abstract-floating-lighting-meteorite-rocks-simple-background-spheres.jpg" />
    <Content Include="images\shivani\img.w\6006.jpg" />
    <Content Include="images\shivani\img.w\704695_simple-simple-backgrounds-hd-backgrounds-walldevil-best-free-hd_1920x1080_h.jpg" />
    <Content Include="images\shivani\img.w\704705_light-minimalistic-vignette-simple-backgrounds-wallpapers_1920x1080_h.jpg" />
    <Content Include="images\shivani\img.w\712f19fd0eec5a3e351849676681d9cc.jpg" />
    <Content Include="images\shivani\img.w\a9ab54d4eb844a31ce50ffb724ddd754.jpg" />
    <Content Include="images\shivani\img.w\ayurveda-medicines_0.jpg" />
    <Content Include="images\shivani\img.w\ayurveda_medicine-966x483.jpg" />
    <Content Include="images\shivani\img.w\background-2887350_960_720.jpg" />
    <Content Include="images\shivani\img.w\blue_background_wave_abstract_77125_3840x2400.jpg" />
    <Content Include="images\shivani\img.w\christmas_lights_photography_hd_wallpapers.jpg" />
    <Content Include="images\shivani\img.w\d0a1332e7cec4b6db6d96eaa7ad6a955--red-wallpaper-pc-computer.jpg" />
    <Content Include="images\shivani\img.w\download %281%29.jpg" />
    <Content Include="images\shivani\img.w\download %281%29.png" />
    <Content Include="images\shivani\img.w\download %282%29.jpg" />
    <Content Include="images\shivani\img.w\download %282%29.png" />
    <Content Include="images\shivani\img.w\download.jpg" />
    <Content Include="images\shivani\img.w\download.png" />
    <Content Include="images\shivani\img.w\free-wallpaper-05.jpg" />
    <Content Include="images\shivani\img.w\glow_wave_abstract_background_51907_300x187.jpg" />
    <Content Include="images\shivani\img.w\images %281%29.jpg" />
    <Content Include="images\shivani\img.w\images %2810%29.jpg" />
    <Content Include="images\shivani\img.w\images %282%29.jpg" />
    <Content Include="images\shivani\img.w\images %283%29.jpg" />
    <Content Include="images\shivani\img.w\images %284%29.jpg" />
    <Content Include="images\shivani\img.w\images %285%29.jpg" />
    <Content Include="images\shivani\img.w\images %286%29.jpg" />
    <Content Include="images\shivani\img.w\images %287%29.jpg" />
    <Content Include="images\shivani\img.w\images %288%29.jpg" />
    <Content Include="images\shivani\img.w\images %289%29.jpg" />
    <Content Include="images\shivani\img.w\images.jpg" />
    <Content Include="images\shivani\img.w\images.png" />
    <Content Include="images\shivani\img.w\marketing-and-selling-personal-care-products.jpg" />
    <Content Include="images\shivani\img.w\openbook-blank-page-hd-wallpaper-1920x1200.jpg" />
    <Content Include="images\shivani\img.w\Pink-Butterfly-Design.gif" />
    <Content Include="images\shivani\img.w\Shine-beautiful-abstract-background-wallpapers.jpg" />
    <Content Include="images\shivani\img.w\simple-background-purple-720P-wallpaper-middle-size.jpg" />
    <Content Include="images\shivani\img.w\Simple-Butterfly-Design.jpg" />
    <Content Include="images\shivani\img.w\simple_gradient_wallpaper_by_adammburleighphoto-d54upk7.png" />
    <Content Include="images\shivani\img.w\What-is-Ayurveda.jpg" />
    <Content Include="images\shivani\img.w\winter-background-hd-40.jpg" />
    <Content Include="images\shivani\img.w\zen_stones_background-wallpaper-1280x720-1024x576.jpg" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>